using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Design;

namespace Project_Iris
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public class KonboBox : UserControl
    {
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 0;
        private int borderCurve = 15;
        private ComboBox Combo;
        private Label Textlabel;
        private Button ArrowBttn;
        public event EventHandler OnSelectedIndexChanged;
        public KonboBox()
        {
            Combo = new ComboBox();
            Textlabel = new Label();
            ArrowBttn = new Button();
            this.SuspendLayout();

            //ComboBox: Dropdown list
            Combo.BackColor = listBackColor;
            Combo.Font = new Font(this.Font.Name, 10F);
            Combo.ForeColor = listTextColor;
            Combo.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            Combo.TextChanged += new EventHandler(ComboBox_TextChanged);
            //Button: Icon
            ArrowBttn.Dock = DockStyle.Right;
            ArrowBttn.FlatStyle = FlatStyle.Flat;
            ArrowBttn.FlatAppearance.BorderSize = 0;
            ArrowBttn.BackColor = backColor;
            ArrowBttn.Size = new Size(30, 30);
            ArrowBttn.Click += new EventHandler(Arrow_Click);
            ArrowBttn.Paint += new PaintEventHandler(ArrowDraw);

            //Label: Text
            Textlabel.Dock = DockStyle.Fill;
            Textlabel.AutoSize = false;
            Textlabel.BackColor = backColor;
            Textlabel.TextAlign = ContentAlignment.MiddleLeft;
            Textlabel.Padding = new Padding(8, 0, 0, 0);
            Textlabel.Font = new Font(this.Font.Name, 10F);
            Textlabel.Click += new EventHandler(Textlabel_Click);
            Textlabel.MouseEnter += new EventHandler(Textlabel_MouseEnter);
            Textlabel.MouseLeave += new EventHandler(Textlabel_MouseLeave);

            //User Control
            this.Controls.Add(Textlabel);//2
            this.Controls.Add(ArrowBttn);//1
            this.Controls.Add(Combo);//0
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);
            this.Font = new Font(this.Font.Name, 10F);
            base.BackColor = borderColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        [Category("RoundCombo")]
        public new Color BackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                Textlabel.BackColor = backColor;
                ArrowBttn.BackColor = backColor;
            }
        }

        [Category("RoundCombo")]
        public Color IconColor
        {
            get { return iconColor; }
            set
            {
                iconColor = value;
                ArrowBttn.Invalidate();
            }
        }

        [Category("RoundCombo")]
        public Color ListBackColor
        {
            get { return listBackColor; }
            set
            {
                listBackColor = value;
                Combo.BackColor = listBackColor;
            }
        }

        [Category("RoundCombo")]
        public Color ListTextColor
        {
            get { return listTextColor; }
            set
            {
                listTextColor = value;
                Combo.ForeColor = listTextColor;
            }
        }

        [Category("RoundCombo")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                base.BackColor = borderColor; //Border Color
            }
        }

        /*[Category("RoundCombo")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);//Border Size
                AdjustComboBoxDimensions();
            }
        }*/
        [Category("RoundCombo")]
        public int BorderCurve
        {
            get { return borderCurve; }
            set { borderCurve = value; }
        }
        [Category("RoundCombo")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                Textlabel.ForeColor = value;
            }
        }

        [Category("RoundCombo")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                Textlabel.Font = value;
                Combo.Font = value;//Optional
            }
        }

        [Category("RoundCombo")]
        public string Texts
        {
            get { return Textlabel.Text; }
            set { Textlabel.Text = value; }
        }

        [Category("RoundCombo")]
        public ComboBoxStyle DropDownStyle
        {
            get { return Combo.DropDownStyle; }
            set
            {
                if (Combo.DropDownStyle != ComboBoxStyle.Simple)
                    Combo.DropDownStyle = value;
            }
        }
        [Category("RoundCombo")]
        [DefaultValue("MiddleLeft")]
        public ContentAlignment TextAlignment
        {
            get { return Textlabel.TextAlign; }
            set { Textlabel.TextAlign = value; }
        }
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, -90, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderCurve > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderCurve))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderCurve - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    this.Region = new Region(pathSurface);
                    e.Graphics.DrawPath(penSurface, pathSurface);
                    if (borderSize >= 1)
                        e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                e.Graphics.SmoothingMode = SmoothingMode.None;
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        //Crredit to RJ Code Advance https://www.youtube.com/c/RJCodeAdvanceEN
        [Category("RJ Code - Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return Combo.Items; }
        }

        [Category("RJ Code - Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get { return Combo.DataSource; }
            set { Combo.DataSource = value; }
        }

        [Category("RJ Code - Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return Combo.AutoCompleteCustomSource; }
            set { Combo.AutoCompleteCustomSource = value; }
        }

        [Category("RJ Code - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return Combo.AutoCompleteSource; }
            set { Combo.AutoCompleteSource = value; }
        }

        [Category("RJ Code - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return Combo.AutoCompleteMode; }
            set { Combo.AutoCompleteMode = value; }
        }

        [Category("RJ Code - Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get { return Combo.SelectedItem; }
            set { Combo.SelectedItem = value; }
        }

        [Category("RJ Code - Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get { return Combo.SelectedIndex; }
            set { Combo.SelectedIndex = value; }
        }

        [Category("RJ Code - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string DisplayMember
        {
            get { return Combo.DisplayMember; }
            set { Combo.DisplayMember = value; }
        }

        [Category("RJ Code - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get { return Combo.ValueMember; }
            set { Combo.ValueMember = value; }
        }

        //Private methods
        private void AdjustComboBoxDimensions()
        {
            Combo.Width = Textlabel.Width;
            Combo.Location = new Point()
            {
                X = this.Width - this.Padding.Right - Combo.Width,
                Y = Textlabel.Bottom - Combo.Height
            };
        }

        //Event methods

        //-> Default event
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            ArrowBttn.Paint += new PaintEventHandler(ArrowDraw);
            Textlabel.Text = Combo.Text;
        }
        private void ArrowDraw(object sender, PaintEventArgs e)
        {
            int iconWidth = 14;
            int iconHeight = 6;
            var arrowIcon = new Rectangle((ArrowBttn.Width - iconWidth) / 2, (ArrowBttn.Height - iconHeight) / 2, iconWidth, iconHeight);
            Brush fill = new SolidBrush(iconColor);
            Graphics graph = e.Graphics;
            {
                using (GraphicsPath path = new GraphicsPath())
                using (Pen pen = new Pen(iconColor, 2))
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    path.AddLine(arrowIcon.X, arrowIcon.Y, arrowIcon.X + (iconWidth / 2), arrowIcon.Bottom);
                    path.AddLine(arrowIcon.X + (iconWidth / 2), arrowIcon.Bottom, arrowIcon.Right, arrowIcon.Y);
                    graph.DrawPath(pen, path);
                }
            }
        }

        //-> Items actions
        private void Arrow_Click(object sender, EventArgs e)
        {
            ArrowBttn.Paint += new PaintEventHandler(ArrowDraw);
            Combo.Select();
            Combo.DroppedDown = true;
        }
        private void Textlabel_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            Combo.Select();
            if (Combo.DropDownStyle == ComboBoxStyle.DropDownList)
                Combo.DroppedDown = true;
            ArrowBttn.Paint += new PaintEventHandler(ArrowDraw);
        }
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            Textlabel.Text = Combo.Text;
        }

        private void Textlabel_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
            ArrowBttn.Paint += new PaintEventHandler(ArrowDraw);        }

        private void Textlabel_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }


    }
}
