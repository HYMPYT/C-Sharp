using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncCounters
{
    public enum CounterMode
    {
        All,
        Queue,
        ReverseQueue,
        Shuffle,
        GroupShuffle
    }

    public partial class MainForm : Form
    {
        private readonly object _locker = new object();
        private CounterMode _currentMode;
        private readonly List<CancellationTokenSource> _cancellationTokensSources = new List<CancellationTokenSource>();
        private readonly int _max = 10;
        private readonly int _maxWithFewLoops;
        private bool _isAllAtMaximum
        {
            get
            {
                lock (_locker)
                {
                    return lCounter0.Text == $"{_max}" &&
                        lCounter1.Text == $"{_max}" &&
                        lCounter2.Text == $"{_max}" &&
                        lCounter3.Text == $"{_max}" &&
                        lCounter4.Text == $"{_max}";
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            _maxWithFewLoops = _max * 5;
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = true;
            StartCountByCurMode();
        }
        
        private void btnStop_Click(object sender, EventArgs e)
        {
            _cancellationTokensSources.ForEach(t => t.Cancel());
            _cancellationTokensSources.Clear();
        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            lCounter0.Text = lCounter1.Text = lCounter2.Text = lCounter3.Text = lCounter4.Text = "0";
            btnReset.Enabled = false;
        }
        
        private void rbAll_CheckedChanged(object sender, EventArgs e) => _currentMode = CounterMode.All;

        private void rbQueue_CheckedChanged(object sender, EventArgs e) => _currentMode = CounterMode.Queue;

        private void rbReverseQueue_CheckedChanged(object sender, EventArgs e) => _currentMode = CounterMode.ReverseQueue;

        private void rbShuffle_CheckedChanged(object sender, EventArgs e) => _currentMode = CounterMode.Shuffle;

        private void rbGrouShuffle_CheckedChanged(object sender, EventArgs e) => _currentMode = CounterMode.GroupShuffle;
     

        
        private void StartCountByCurMode()
        {
            switch (_currentMode)
            {
                case CounterMode.All:
                    StartCountTogeter();
                    break;
                case CounterMode.Queue:
                    StartCountInQueue();
                    break;
                case CounterMode.ReverseQueue:
                    StartCountInReverseQueue();
                    break;
                case CounterMode.Shuffle:
                    StartCountInShuffle();
                    break;
                case CounterMode.GroupShuffle:
                    Task.Factory.StartNew(() => StartCountInGroupShuffle(GetToken()));
                    break;
                default:
                    MessageBox.Show("There is no selected mode.");
                    break;
            }
        }
        
        private void StartCountInGroupShuffle(CancellationToken token)
        {
            while (!_isAllAtMaximum)
            {
                if (token.IsCancellationRequested)
                    break;

                var t0 = Task.Factory.StartNew(() => CountSimple(lCounter0, 1, token));
                var t1 = Task.Factory.StartNew(() => CountSimple(lCounter4, 1, token));
                Task.WaitAll(t0, t1);
                var t2 = Task.Factory.StartNew(() => CountInOrder(token, 1, lCounter1, lCounter2, lCounter3));
                Task.WaitAll(t2);
            }
        }
        
        private void StartCountInShuffle() => Task.Factory.StartNew(() => CountInOrder(GetToken(), _maxWithFewLoops, lCounter0, lCounter2, lCounter4, lCounter1, lCounter3));
        
        private void StartCountInReverseQueue() => Task.Factory.StartNew(() => CountInOrder(GetToken(), _maxWithFewLoops, lCounter4, lCounter3, lCounter2, lCounter1, lCounter0));
        
        private void StartCountInQueue() => Task.Factory.StartNew(() => CountInOrder(GetToken(), _maxWithFewLoops, lCounter0, lCounter1, lCounter2, lCounter3, lCounter4));
        
        private void StartCountTogeter()
        {
            var token = GetToken();

            Task.Factory.StartNew(() => CountSimple(lCounter0, _maxWithFewLoops, token));
            Task.Factory.StartNew(() => CountSimple(lCounter1, _maxWithFewLoops, token));
            Task.Factory.StartNew(() => CountSimple(lCounter2, _maxWithFewLoops, token));
            Task.Factory.StartNew(() => CountSimple(lCounter3, _maxWithFewLoops, token));
            Task.Factory.StartNew(() => CountSimple(lCounter4, _maxWithFewLoops, token));
        }

        
        private void CountInOrder(CancellationToken token, int ticks, params Label[] labels)
        {
            if (ticks > 0)
                foreach (Label lb in labels)
                    CountSimple(lb, 1, token);


            if (!_isAllAtMaximum && ticks > 1)
                CountInOrder(token, --ticks, labels);
        }

        private void CountSimple(Label lb, int ticks, CancellationToken token)
        {
            int curTick = 0;
            while (lb.Text != _max.ToString() && curTick++ < ticks)
            {
                if (token.IsCancellationRequested)
                    break;

                lock (_locker)
                {
                    lb.Invoke((MethodInvoker)delegate { lb.Text = $"{int.Parse(lb.Text) + 1}"; });
                }
                Thread.Sleep(500);
            }

            if (_isAllAtMaximum)
                btnReset.Invoke((MethodInvoker)delegate { btnReset.Enabled = true; });
        }

        
        private CancellationToken GetToken()
        {
            CancellationTokenSource source = new CancellationTokenSource();
            _cancellationTokensSources.Add(source);
            CancellationToken token = source.Token;
            return token;
        }
    }
}