using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientLemonWay.SoapServiceLimomWay;
using log4net;


namespace ClientLemonWay
{
    public partial class Form1 : Form
    {
        //HEADER
        private Point MouseLast;
        private bool HoldHeader = false;


        WebRequester Fibo = new WebRequester("http://176.31.248.121/SoapService.asmx");
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        SynchronizationContext CurrentSync;
        public static bool FinishPaint = true;


        public Form1()
        {
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.DoubleBuffered = true;
            InitializeComponent();
            CurrentSync = WindowsFormsSynchronizationContext.Current;
            this.DoubleBuffered = true;
           
            this.Load += Form1_Load;

            log.Info("Start Program");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SoapTools.AddMethodSoap("Fibonacci", "n");
            SoapTools.AddMethodSoap("XmlToJson", "xml");
        }


        protected override void OnShown(EventArgs e)
        {
            FinishPaint = true;
            base.OnShown(e);
           
        }

       
        protected override void OnPaint(PaintEventArgs e)
        {
           
            FinishPaint = false;
            e.Graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            base.OnPaint(e);
            
        }
  

        private async void FiboCallWeb_Click(object sender, EventArgs e)
        {

            await Request("Fibonacci",Btn_FiboService,57);
       
        }

        private void Loader(bool status)
        {
            if (status)
            {
                LoaderGif.Visible = true;
                Label_load.Visible = true;
                LoaderGif.Image = ClientLemonWay.Properties.Resources.Gear_1s_30px;
                LoaderGif.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                LoaderGif.Visible =false;
                Label_load.Visible = false;
            }
        }

        /// <summary>
        /// Call Request Service Soap Async
        /// </summary>
        private async Task Request(string method,Control control,params object[] values)
        {
            
            await Task.Factory.StartNew(() =>
            {
                try
                {
                    CurrentSync.Post((o) =>
                    {
                        Loader(true);
                        control.Enabled = false;
                    }, null);

                    string Resultat = Fibo.Request(method, TypeHttp.Post, values);

                    CurrentSync.Post((o) =>
                    {
                        Loader(false);
                        control.Enabled = true;
                    }, null);

                    MessageBox.Show(Resultat);
                    log.Info("Method Service "+method + " Work!");
                }
                catch(Exception ex)
                {
                    log.Error("Method Service " + method + "No Work!");
                    log.Error(ex.Message);
                    MessageBox.Show("Error Look Log");
                }

            });
              
        }

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLast = MousePosition;
            HoldHeader = true;
        }

        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (HoldHeader)
            {
                int xDelta = MouseLast.X - MousePosition.X;
                int yDelta = MouseLast.Y - MousePosition.Y;

                MouseLast = MousePosition;

                this.Location = new Point(this.Location.X - xDelta, this.Location.Y - yDelta);
            }
        }

        private void HeaderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            HoldHeader = false;
        }

        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Btn_MaxWin_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }

        private void Btn_min_MouseUp(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void Btn_XmlToJson_Click(object sender, EventArgs e)
        {
            await Request("XmlToJson",Btn_XmlToJson, XmlContent.Text);
        }
    }
}
