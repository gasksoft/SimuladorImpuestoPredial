using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Owf.Controls
{
    public partial class OutlookPanelEx : Panel
    {
        private Color _headerColor1 = Color.FromArgb(89, 135, 214);
        private Color _headerColor2 = Color.FromArgb(3, 56, 147);
        private readonly Font _headerFont = new Font("Segoe UI", 12, FontStyle.Regular);
        private readonly int _headerHeight = 30;
        private string _headerText = "header title";
        private Image _icon;
        private Color _iconTransparentColor = Color.White;

        //public override Rectangle DisplayRectangle
        //{
        //    get
        //    {
        //        Rectangle clientSize = base.DisplayRectangle;
        //        clientSize.X = 20;
        //        clientSize.Height -= 20;
        //        return clientSize;
        //    }
        //}

        public OutlookPanelEx()
        {
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            Padding = new Padding(5, _headerHeight + 4, 5, 4);
        }

        [Browsable(true)]
        [Category("Owf")]
        public string HeaderText
        {
            get { return _headerText; }
            set
            {
                _headerText = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Owf")]
        public Color HeaderColor1
        {
            get { return _headerColor1; }
            set
            {
                _headerColor1 = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Owf")]
        public Color HeaderColor2
        {
            get { return _headerColor2; }
            set
            {
                _headerColor2 = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Owf")]
        public Image Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Owf")]
        public Color IconTransparentColor
        {
            get { return _iconTransparentColor; }
            set
            {
                _iconTransparentColor = value;
                Invalidate();
            }
        }

        private void OutlookPanelEx_Paint(object sender, PaintEventArgs e)
        {
            if (_headerHeight <= 1) return;
            // Draw border;
            DrawBorder(e.Graphics);

            // Draw heaeder
            DrawHeader(e.Graphics);

            // Draw text
            DrawText(e.Graphics);

            // Draw Icon
            DrawIcon(e.Graphics);
        }

        private void DrawBorder(Graphics graphics)
        {
            graphics.DrawRectangle(new Pen(_headerColor2), 0, 0, Width - 1, Height - 1);
        }

        private void DrawHeader(Graphics graphics)
        {
            graphics.FillRectangle(
                new LinearGradientBrush(
                    new Rectangle(1, 1, Width - 2, _headerHeight), 
                    _headerColor1, 
                    _headerColor2, 
                    LinearGradientMode.Vertical),
                new Rectangle(1, 1, Width - 2, _headerHeight));
        }

        private void DrawText(Graphics graphics)
        {
            if (string.IsNullOrEmpty(_headerText)) return;
            using (Brush brush = new SolidBrush(Color.White))
            {
                graphics.DrawString(_headerText, _headerFont, brush, 5, (_headerHeight - graphics.MeasureString(_headerText, _headerFont).Height) / 2);
            }
        }

        private void DrawIcon(Graphics graphics)
        {
            if (_icon == null) return;
            using (var bitmap = new Bitmap(_icon))
            {
                bitmap.MakeTransparent(_iconTransparentColor);
                graphics.DrawImage(bitmap, new Point(Width - _icon.Width - 2, (_headerHeight - _icon.Height) / 2));
            }
        }
    }
}