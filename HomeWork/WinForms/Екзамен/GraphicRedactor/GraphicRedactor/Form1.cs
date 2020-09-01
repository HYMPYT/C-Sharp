using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace GraphicRedactor
{
    public partial class Form1 : Form
    {
        public Color LeftColor { get; set; }
        public Color RightColor { get; set; }
        public Color ColorField { get; set; }
        public Pen PencilPen { get; set; }

        private string openfileName = "";
        bool resizing = false;
        int resizingMargin;
        private Point startDraggingPoint;
        private Point clickPoint;
        private Size startSize;
        PictureBox draggedPiece = null;
        Rectangle rectProposedSize = Rectangle.Empty;
        static int count = 1;

        Item currItem;
        public Form1()
        {
            InitializeComponent();
            GraphicField.Image = new Bitmap(GraphicField.Width, GraphicField.Height);
            LeftColor = LeftColorBtn.BackColor;
            RightColor = RightColorBtn.BackColor;
            Pencil.Enabled = false;
            currItem = Item.Pencil;
            Pencil.BackColor = Color.LightCyan;
            resizingMargin = 5;
            GraphicField.Cursor = Cursors.Cross;
        }

        public enum Item
        {
            Rectangle, Ellipse, Line, Pencil, Pipette, Erase
        }
        
        private void Pencil_Click(object sender, EventArgs e)
        {
            Pencil.Enabled = false;
            Pipette.Enabled = true;
            Erase.Enabled = true;
            RectangleBtn.Enabled = true;
            EllipseBtn.Enabled = true;
            LineBtn.Enabled = true;
            Pipette.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            Erase.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            Pencil.BackColor = Color.LightCyan;
            LineBtn.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            RectangleBtn.BackColor = EllipseBtn.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            EllipseBtn.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            currItem = Item.Pencil;
        }

        private void Color_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RightColor = (Color)sender.GetType().GetProperty("BackColor").GetValue(sender);
                RightColorBtn.BackColor = RightColor;
            }
            if (e.Button == MouseButtons.Left)
            {
                LeftColor = (Color)sender.GetType().GetProperty("BackColor").GetValue(sender);
                LeftColorBtn.BackColor = LeftColor;
            }
        }

        private void Erase_Click(object sender, EventArgs e)
        {
            Pencil.Enabled = true;
            Pipette.Enabled = true;
            Erase.Enabled = false;
            RectangleBtn.Enabled = true;
            EllipseBtn.Enabled = true;
            LineBtn.Enabled = true;
            Pipette.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            Erase.BackColor = Color.LightCyan;
            Pencil.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            LineBtn.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            RectangleBtn.BackColor = EllipseBtn.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            EllipseBtn.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            currItem = Item.Erase;
        }

        private void Pipette_Click(object sender, EventArgs e)
        {
            GraphicField.Cursor = Cursors.Hand;
            Pencil.Enabled = true;
            Pipette.Enabled = false;
            Erase.Enabled = true;
            RectangleBtn.Enabled = true;
            EllipseBtn.Enabled = true;
            LineBtn.Enabled = true;
            Pipette.BackColor = Color.LightCyan;
            Erase.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            Pencil.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            LineBtn.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            RectangleBtn.BackColor = EllipseBtn.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            EllipseBtn.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            currItem = Item.Pipette;
        }

        private void LineBtn_Click(object sender, EventArgs e)
        {
            Pencil.Enabled = true;
            Pipette.Enabled = true;
            Erase.Enabled = true;
            RectangleBtn.Enabled = true;
            EllipseBtn.Enabled = true;
            LineBtn.Enabled = false;
            Pipette.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            Erase.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            Pencil.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            LineBtn.BackColor = Color.LightCyan;
            RectangleBtn.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            EllipseBtn.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            currItem = Item.Line;
        }

        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            Pencil.Enabled = true;
            Pipette.Enabled = true;
            Erase.Enabled = true;
            RectangleBtn.Enabled = false;
            EllipseBtn.Enabled = true;
            LineBtn.Enabled = true;
            Pipette.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            Erase.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            Pencil.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            LineBtn.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            RectangleBtn.BackColor = Color.LightCyan;
            EllipseBtn.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            currItem = Item.Rectangle;
        }

        private void EllipseBtn_Click(object sender, EventArgs e)
        {
            Pencil.Enabled = true;
            Pipette.Enabled = true;
            Erase.Enabled = true;
            RectangleBtn.Enabled = true;
            EllipseBtn.Enabled = false;
            LineBtn.Enabled = true;
            Pipette.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            Erase.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            Pencil.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            LineBtn.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            RectangleBtn.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            EllipseBtn.BackColor = Color.LightCyan;
            currItem = Item.Ellipse;
        }

        private void повернутьНа90ВлевоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(GraphicField.Width, GraphicField.Height);
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
            gfx.RotateTransform(-90);
            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gfx.DrawImage(GraphicField.Image, new Point(0, 0));
            gfx.Dispose();
            GraphicField.Image = bmp;
        }

        private void повернутьНа90ВправоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(GraphicField.Width, GraphicField.Height);
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
            gfx.RotateTransform(90);
            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gfx.DrawImage(GraphicField.Image, new Point(0, 0));
            gfx.Dispose();
            GraphicField.Image = bmp;
        }

        private void повернутьНа180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(GraphicField.Width, GraphicField.Height);
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
            gfx.RotateTransform(180);
            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gfx.DrawImage(GraphicField.Image, new Point(0, 0));
            gfx.Dispose();
            GraphicField.Image = bmp;
        }

        private void отразитьПоГоризоналиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphicField.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            GraphicField.Invalidate();
        }

        private void отразитьПоВертикалиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphicField.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            GraphicField.Invalidate();
        }

        private void GraphicField_MouseDown(object sender, MouseEventArgs e)
        {
            startDraggingPoint = e.Location;
            switch (currItem)
            {
                case Item.Rectangle:
                    clickPoint = e.Location;
                    break;

                case Item.Ellipse:
                    clickPoint = e.Location;
                    break;
                    
                case Item.Pipette:
                    Bitmap bmp = new Bitmap(GraphicField.Width, GraphicField.Height);
                    Graphics g = Graphics.FromImage(bmp);
                    Rectangle rect = GraphicField.RectangleToScreen(GraphicField.ClientRectangle);
                    g.CopyFromScreen(rect.Location, Point.Empty, GraphicField.Size);
                    g.Dispose();
                    if (e.Button == MouseButtons.Left)
                    {
                        LeftColor = bmp.GetPixel(startDraggingPoint.X, startDraggingPoint.Y);
                        LeftColorBtn.BackColor = LeftColor;
                    }
                    if (e.Button == MouseButtons.Right)
                    {
                        RightColor = bmp.GetPixel(startDraggingPoint.X, startDraggingPoint.Y);
                        RightColorBtn.BackColor = RightColor;
                    }
                    bmp.Dispose();
                    break;

                default:
                    draggedPiece = sender as PictureBox;
                    if ((e.X >= GraphicField.Width - resizingMargin) || (e.Y >= GraphicField.Height - resizingMargin))
                    {
                        Pencil.Enabled = Pipette.Enabled = Erase.Enabled = LineBtn.Enabled = RectangleBtn.Enabled = EllipseBtn.Enabled = true;

                        resizing = true;

                        this.Cursor = Cursors.SizeNWSE;

                        startSize = new Size(e.X, e.Y);
                        rectProposedSize = new Rectangle(draggedPiece.Location.X, draggedPiece.Location.Y + 180, startSize.Width, startSize.Height);

                        ControlPaint.DrawReversibleFrame(rectProposedSize, this.ForeColor, FrameStyle.Dashed);
                    }
                    else
                    {
                        resizing = false;
                    }
                    break;
            }
        }

        private void GraphicField_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(GraphicField.Image);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (draggedPiece != null && resizing)
            {
                if (rectProposedSize.Width > 0 && rectProposedSize.Height > 0)
                    ControlPaint.DrawReversibleFrame(rectProposedSize, this.ForeColor, FrameStyle.Dashed);
                rectProposedSize.Width = e.X - startDraggingPoint.X + startSize.Width;
                rectProposedSize.Height = e.Y - startDraggingPoint.Y + startSize.Height;
                if (rectProposedSize.Width > 0 && rectProposedSize.Height > 0)
                    ControlPaint.DrawReversibleFrame(rectProposedSize, this.ForeColor, FrameStyle.Dashed);
            }
            else
            {
                switch (currItem)
                {
                    case Item.Pencil:
                        GraphicField.Cursor = Cursors.Cross;
                        if (e.Button == MouseButtons.Left)
                        {
                            PencilPen = new Pen(LeftColor, (float)WidthLine.Value * 2);
                            PencilPen.StartCap = PencilPen.EndCap = LineCap.Round;
                            g.DrawLine(PencilPen, startDraggingPoint.X, startDraggingPoint.Y, e.X, e.Y);
                            startDraggingPoint.X = e.X;
                            startDraggingPoint.Y = e.Y;
                            GraphicField.Invalidate();
                        }
                        else if (e.Button == MouseButtons.Right)
                        {
                            PencilPen = new Pen(RightColor, (float)WidthLine.Value * 2);
                            PencilPen.StartCap = PencilPen.EndCap = LineCap.Round;
                            g.DrawLine(PencilPen, startDraggingPoint.X, startDraggingPoint.Y, e.X, e.Y);
                            startDraggingPoint.X = e.X;
                            startDraggingPoint.Y = e.Y;
                            GraphicField.Invalidate();
                        }
                        break;

                    case Item.Rectangle:
                        if (e.Button == MouseButtons.Left)
                        {
                            PencilPen = new Pen(LeftColor, (float)WidthLine.Value * 2);
                            PencilPen.StartCap = PencilPen.EndCap = LineCap.Round;
                            g.FillRectangle(new SolidBrush(RightColor), clickPoint.X, clickPoint.Y, e.X - clickPoint.X, e.Y - clickPoint.Y);
                            g.DrawRectangle(PencilPen, clickPoint.X, clickPoint.Y, e.X - clickPoint.X, e.Y - clickPoint.Y);
                            GraphicField.Invalidate();
                        }
                        else if (e.Button == MouseButtons.Right)
                        {
                            PencilPen = new Pen(RightColor, (float)WidthLine.Value * 2);
                            PencilPen.StartCap = PencilPen.EndCap = LineCap.Round;
                            g.FillRectangle(new SolidBrush(LeftColor), clickPoint.X, clickPoint.Y, e.X - clickPoint.X, e.Y - clickPoint.Y);
                            g.DrawRectangle(PencilPen, clickPoint.X, clickPoint.Y, e.X - clickPoint.X, e.Y - clickPoint.Y);
                            GraphicField.Invalidate();
                        }
                        break;

                    case Item.Ellipse:
                        
                        break;

                    case Item.Erase:
                        if (e.Button == MouseButtons.Left)
                        {
                            SolidBrush s = new SolidBrush(RightColor);
                            g.FillRectangle(s, startDraggingPoint.X, startDraggingPoint.Y, (float)WidthLine.Value * 12, (float)WidthLine.Value * 12);
                            startDraggingPoint.X = e.X;
                            startDraggingPoint.Y = e.Y;
                            GraphicField.Invalidate();
                        }
                        break;
                }
            }
        }

        private void GraphicField_MouseUp(object sender, MouseEventArgs e)
        {
            if (currItem == Item.Line)
            {
                Graphics g = Graphics.FromImage(GraphicField.Image);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                if (e.Button == MouseButtons.Left)
                {
                    PencilPen = new Pen(LeftColor, (float)WidthLine.Value * 2);
                    PencilPen.StartCap = PencilPen.EndCap = LineCap.Round;
                    g.DrawLine(PencilPen, startDraggingPoint.X, startDraggingPoint.Y, e.X, e.Y);
                    GraphicField.Invalidate();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    PencilPen = new Pen(RightColor, (float)WidthLine.Value * 2);
                    PencilPen.StartCap = PencilPen.EndCap = LineCap.Round;
                    g.DrawLine(PencilPen, startDraggingPoint.X, startDraggingPoint.Y, e.X, e.Y);
                    GraphicField.Invalidate();
                }
            }
            else if(currItem == Item.Ellipse)
            {
                Graphics g = Graphics.FromImage(GraphicField.Image);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                if (e.Button == MouseButtons.Left)
                {
                    PencilPen = new Pen(LeftColor, (float)WidthLine.Value * 2);
                    PencilPen.StartCap = PencilPen.EndCap = LineCap.Round;
                    g.FillEllipse(new SolidBrush(RightColor), clickPoint.X, clickPoint.Y, e.X - clickPoint.X, e.Y - clickPoint.Y);
                    g.DrawEllipse(PencilPen, clickPoint.X, clickPoint.Y, e.X - clickPoint.X, e.Y - clickPoint.Y);
                    GraphicField.Invalidate();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    PencilPen = new Pen(RightColor, (float)WidthLine.Value * 2);
                    PencilPen.StartCap = PencilPen.EndCap = LineCap.Round;
                    g.FillEllipse(new SolidBrush(LeftColor), clickPoint.X, clickPoint.Y, e.X - clickPoint.X, e.Y - clickPoint.Y);
                    g.DrawEllipse(PencilPen, clickPoint.X, clickPoint.Y, e.X - clickPoint.X, e.Y - clickPoint.Y);
                    GraphicField.Invalidate();
                }
            }
            if (resizing)
            {
                Bitmap bmp;
                Graphics g;
                if (rectProposedSize.Width > 0 && rectProposedSize.Height > 0)
                {
                    ControlPaint.DrawReversibleFrame(rectProposedSize, this.ForeColor, FrameStyle.Dashed);
                }
                if (rectProposedSize.Width > 10 && rectProposedSize.Height > 10)
                {
                    draggedPiece.Size = rectProposedSize.Size;
                    bmp = new Bitmap(draggedPiece.Width, draggedPiece.Height);
                    g = Graphics.FromImage(bmp);
                    g.DrawImage(GraphicField.Image, 0, 0);
                    GraphicField.Image = bmp;
                }
                else
                {
                    draggedPiece.Size = new Size(Math.Max(10, rectProposedSize.Width), Math.Max(10, rectProposedSize.Height));
                    bmp = new Bitmap(draggedPiece.Width, draggedPiece.Height);
                    g = Graphics.FromImage(bmp);
                    g.DrawImage(GraphicField.Image, 0, 0);
                    GraphicField.Image = bmp;
                }
            }
            GraphicField.Cursor = Cursors.Default;
            this.draggedPiece = null;
            this.startDraggingPoint = Point.Empty;
            this.Cursor = Cursors.Default;
        }

        private void GraphicField_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ColorMixer_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                for (int i = 5; i < 35; i++)
                {
                    if (cd.Color == groupBox4.Controls[$"button{i}"].BackColor)
                        return;
                }

                if (button25.BackColor == Color.White)
                {
                    button25.BackColor = cd.Color;
                }
                else
                {
                    if (count == 10)
                    {
                        for (int i = 25; i < 34; i++)
                        {
                            groupBox4.Controls[$"button{i}"].BackColor = groupBox4.Controls[$"button{i + 1}"].BackColor;
                        }
                        button34.BackColor = cd.Color;
                    }
                    else
                    {
                        for (int i = 26; i < 35; i++)
                        {
                            if ((groupBox4.Controls[$"button{i}"] as Button).BackColor == Color.White)
                            {
                                groupBox4.Controls[$"button{i}"].BackColor = cd.Color;
                                count++;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void ResizeBtn_Click(object sender, EventArgs e)
        {
            ChangeSizeForm csf = new ChangeSizeForm(GraphicField.Height, GraphicField.Width);
            if (csf.ShowDialog() == DialogResult.OK)
            {
                if (csf.Chose == "Проценты")
                {
                    int width = GraphicField.Size.Width * csf.WidthProc / 100;
                    int height = GraphicField.Size.Height * csf.HeightProc / 100;
                    draggedPiece = GraphicField as PictureBox;
                    draggedPiece.Size = new Size(width, height);
                    Bitmap bmp = new Bitmap(GraphicField.Image, width, height);
                    GraphicField.Image = bmp;
                    draggedPiece = null;
                }
                else if (csf.Chose == "Пиксели")
                {
                    draggedPiece = GraphicField as PictureBox;
                    draggedPiece.Size = new Size(csf.NewWidth, csf.NewHeight);
                    Bitmap bmp = new Bitmap(GraphicField.Image, csf.NewWidth, csf.NewHeight);
                    GraphicField.Image = bmp;
                    draggedPiece = null;
                }
            }
        }

        public Point? GetMismatchPoint(Bitmap bmp1, Bitmap bmp2)
        {
            using (var wr1 = new ImageWrapper(bmp1))
            using (var wr2 = new ImageWrapper(bmp2))
                foreach (var p in wr1)
                    if (wr1[p] != wr2[p])
                        return p;

            return null;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(GraphicField.Width, GraphicField.Height);
            Point? p = GetMismatchPoint(bmp, (Bitmap)GraphicField.Image);
            if (p == null)
            {
                GraphicField.Refresh();
                GraphicField.Image = bmp;
            }
            else
            {
                if (openfileName == "")
                {
                    QuestionForm qf = new QuestionForm();
                    if (qf.ShowDialog() == DialogResult.OK)
                    {
                        SaveBtn_Click(sender, e);
                    }
                    if (qf.DialogResult == DialogResult.No)
                    {
                        GraphicField.Refresh();
                        GraphicField.Image = bmp;
                    }
                }
                else
                {
                    QuestionForm qf = new QuestionForm(openfileName);
                    if (qf.ShowDialog() == DialogResult.OK)
                    {
                        SaveBtn_Click(sender, e);
                    }
                    if (qf.DialogResult == DialogResult.No)
                    {
                        GraphicField.Refresh();
                        GraphicField.Image = bmp;
                    }
                }
            }
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Все файлы изображений(*.BMP;*.PNG;*.JPEG)|*.BMP;*.PNG;*.JPG|PNG|*.png|JPEG|*.jpg;*.jpeg;*.jpe;*.jfif|BMP|*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                openfileName = ofd.SafeFileName;
                GraphicField.Size = Image.FromFile(ofd.FileName).Size;
                GraphicField.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(GraphicField.Width, GraphicField.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = GraphicField.RectangleToScreen(GraphicField.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, GraphicField.Size);
            g.Dispose();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Все файлы изображений(*.BMP;*.PNG;*.JPEG)|*.BMP;*.PNG;*.JPG|PNG|*.png|JPEG|*.jpg;*.jpeg;*.jpe;*.jfif|BMP|*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FileName.Contains(".png"))
                {
                    bmp.Save(sfd.FileName, ImageFormat.Png);
                }
                else if (sfd.FileName.Contains(".jpg"))
                {
                    bmp.Save(sfd.FileName, ImageFormat.Jpeg);
                }
                else if (sfd.FileName.Contains(".bmp"))
                {
                    bmp.Save(sfd.FileName, ImageFormat.Bmp);
                }
            }
        }
    }
}
