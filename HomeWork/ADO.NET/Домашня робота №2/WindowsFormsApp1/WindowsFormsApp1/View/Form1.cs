using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ViewModel;

/// <summary>
/// Создайте приложение WindowsForms для управления транзакциями
/// по перечислению средств с одного указанного банковского счета
/// на другой с выбором отправителя и получателя из списка
/// зарегистрированных счетов.
/// При этом следует использовать транзакции из опорного примера.
/// </summary>
namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        CardsView _cv = new CardsView("LocalCardsDB", true);

        public MainForm()
        {
            InitializeComponent();
            ToolTip tt = new ToolTip();
            tt.SetToolTip(tbFilter, "Press \"Enter\" to filter.");
            tt.SetToolTip(cbFromCard, "Card from which will money be transferred.");
            tt.SetToolTip(cbFromCard, "Card to which will money be transferred.");
            tt.SetToolTip(nudMoneyToTransfer, "Money amount to transferr.");

            try
            {
                dgvCards.DataSource = _cv.GetView();
                _cv.LoadData();

                UpdateUserView();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex}\n");
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateUserView()
        {
            cbFromCard.DataSource = _cv.ObjColl;
            cbToCard.DataSource = _cv.ObjColl.Where(c => c != cbFromCard.SelectedItem).ToList<Model.Card>();
            cbFromCard.DisplayMember = cbToCard.DisplayMember = "FName";
            cbFromCard.ValueMember = cbToCard.ValueMember = "Id";
            nudMoneyToTransfer.Value = nudMoneyToTransfer.Maximum = Math.Floor(((Model.Card)cbFromCard.SelectedItem).MoneyOnCard);
            nudMoneyToTransfer.Increment = Math.Floor(nudMoneyToTransfer.Value / 10);
        }

        private void cbFromCard_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateUserView();
        }

        private void tbFilter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dgvCards.DataSource = _cv.GetView(tbFilter.Text.Trim(' '));
        }

        private void bTransferr_Click(object sender, EventArgs e)
        {
            try
            {
                if (_cv.MoneyTransaction(nudMoneyToTransfer.Value, (int)cbFromCard.SelectedValue, (int)cbToCard.SelectedValue))
                {
                    _cv.LoadData();
                    dgvCards.DataSource = _cv.GetView();
                    UpdateUserView();
                    MessageBox.Show("Transaction Successful");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.Message);
            }
        }
    }
}