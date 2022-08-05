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

namespace FColorManager
{
    public partial class MainForm : Form
    {
        float zoom = 10;
        bool fixate = false;
        public MainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += AnalKey;

            l_zoom.Text = (zoom / 100).ToString();
        }
        private void AnalKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                fixate = !fixate;

            l_info.Text = (fixate) ? "Нажмите на данные чтоб скопировать" : "Нажмите Space для фиксации";
        }
        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private static String RGBConverter(System.Drawing.Color c)
        {
            return c.R.ToString() + "; " + c.G.ToString() + "; " + c.B.ToString();
        }
        private void T_zoom_Tick(object sender, EventArgs e)
        {
            if (!fixate)
            {
                Bitmap bmp = new Bitmap((int)(pb_zoom.Size.Width * (zoom / 100)), (int)(pb_zoom.Size.Height * (zoom / 100)));
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(Cursor.Position.X - (int)(pb_zoom.Size.Width * (zoom / 100)) / 2, Cursor.Position.Y - (int)(pb_zoom.Size.Width * (zoom / 100)) / 2, 0, 0, new Size((int)(pb_zoom.Size.Width * (zoom / 100)), (int)(pb_zoom.Size.Width * (zoom / 100))));
                }

                pb_zoom.Image = bmp;

                l_r_rgb.Text = RGBConverter(bmp.GetPixel(bmp.Width / 2, bmp.Height / 2));
                l_r_hex.Text = HexConverter(bmp.GetPixel(bmp.Width / 2, bmp.Height / 2));
            }

        }


        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            zoom = trackBar1.Value;
            l_zoom.Text = (zoom / 100).ToString();
        }

        private void L_r_rgb_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(l_r_rgb.Text);

            Thread t = new Thread(() => {
                for (int i = 0; i < 3; i++) {
                    l_r_rgb.ForeColor = Color.Red;
                    Thread.Sleep(100);
                    l_r_rgb.ForeColor = Color.Black;
                    Thread.Sleep(100);
                }
            });
            t.Start();
        }

        private void L_r_hex_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(l_r_hex.Text);

            Thread t = new Thread(() => {
                for (int i = 0; i < 3; i++)
                {
                    l_r_hex.ForeColor = Color.Red;
                    Thread.Sleep(100);
                    l_r_hex.ForeColor = Color.Black;
                    Thread.Sleep(100);
                }
            });
            t.Start();
        }
    }
}
