using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLemonWay
{
    class PanelCuston : Panel
    {
        private const int WS_EX_TRANSPARENT = 0x20;
        public PanelCuston()
        {
            
            this.SetStyle(ControlStyles.Opaque, true);
           
            this.BackColor = System.Drawing.Color.FromArgb(0,Color.Transparent);
            this.Size = new Size(200, 200);
        }


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
             using (var brush = new SolidBrush(Color.FromArgb(50 * 255 / 100, this.BackColor)))
               {
                   e.Graphics.FillRectangle(brush, this.ClientRectangle);
               }
           // base.OnPaint(e);
        }
    }

    class PictCustom : Control
    {
        private Image imag;
        int frameMax;
        int CurrentFrame = 0;
        FrameDimension fd;
        int TickFrame = 1;
        int tickCurrent = 0;
        bool FirstF = false;
        Graphics tempo;
        Bitmap t;
        public PictCustom(Image img,Size si)
        {
            this.Size = si;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        
            BackColor = Color.Transparent;
            t = new Bitmap(img, this.Size.Width, this.Size.Width);

            imag = img;
            fd = new FrameDimension(img.FrameDimensionsList[0]);
            frameMax = img.GetFrameCount(fd);
            imag.SelectActiveFrame(fd, 0);
           
             
            this.Paint += PictCustom_Paint;
            
        }

        private void PictCustom_Paint(object sender, PaintEventArgs e)
        {
            //   e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //  e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            
            //this.CreateGraphics();
            if (tickCurrent >TickFrame)
            {
                if(CurrentFrame >= frameMax-1)
                {
                    CurrentFrame = 0;
                }
                else
                CurrentFrame++;
                tickCurrent = 0;
                imag.SelectActiveFrame(fd, CurrentFrame);
            }
            else
            {
                tickCurrent++;
            }

            
           // e.Graphics.Clear(Color.Empty);
            e.Graphics.DrawImage(imag, 0, 0);

            Form1.FinishPaint = true;
           // base.OnPaint(e);

        }

        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x20;
                return cp;
            }
        }

       
    }

}
