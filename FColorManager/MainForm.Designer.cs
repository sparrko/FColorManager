namespace FColorManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.t_zoom = new System.Windows.Forms.Timer(this.components);
            this.pb_zoom = new FColorManager.InterpolatingPictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_info = new System.Windows.Forms.Label();
            this.l_r_hex = new System.Windows.Forms.Label();
            this.l_r_rgb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_zoom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_zoom
            // 
            this.t_zoom.Enabled = true;
            this.t_zoom.Interval = 16;
            this.t_zoom.Tick += new System.EventHandler(this.T_zoom_Tick);
            // 
            // pb_zoom
            // 
            this.pb_zoom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pb_zoom.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
            this.pb_zoom.Location = new System.Drawing.Point(12, 12);
            this.pb_zoom.Name = "pb_zoom";
            this.pb_zoom.Size = new System.Drawing.Size(200, 200);
            this.pb_zoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_zoom.TabIndex = 0;
            this.pb_zoom.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trackBar1.Location = new System.Drawing.Point(81, 220);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar1.Size = new System.Drawing.Size(378, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(113, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 200);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(12, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.l_info);
            this.groupBox1.Controls.Add(this.l_r_hex);
            this.groupBox1.Controls.Add(this.l_r_rgb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(226, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 198);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цвет:";
            // 
            // l_info
            // 
            this.l_info.Location = new System.Drawing.Point(9, 99);
            this.l_info.Name = "l_info";
            this.l_info.Size = new System.Drawing.Size(214, 88);
            this.l_info.TabIndex = 4;
            this.l_info.Text = "Нажмите Space для фиксации";
            this.l_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_r_hex
            // 
            this.l_r_hex.Location = new System.Drawing.Point(72, 61);
            this.l_r_hex.Name = "l_r_hex";
            this.l_r_hex.Size = new System.Drawing.Size(138, 20);
            this.l_r_hex.TabIndex = 3;
            this.l_r_hex.Text = "HEX:";
            this.l_r_hex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.l_r_hex.Click += new System.EventHandler(this.L_r_hex_Click);
            // 
            // l_r_rgb
            // 
            this.l_r_rgb.Location = new System.Drawing.Point(72, 32);
            this.l_r_rgb.Name = "l_r_rgb";
            this.l_r_rgb.Size = new System.Drawing.Size(140, 20);
            this.l_r_rgb.TabIndex = 2;
            this.l_r_rgb.Text = "RGB:";
            this.l_r_rgb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.l_r_rgb.Click += new System.EventHandler(this.L_r_rgb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "HEX:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RGB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zoom:";
            // 
            // l_zoom
            // 
            this.l_zoom.AutoSize = true;
            this.l_zoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_zoom.Location = new System.Drawing.Point(13, 241);
            this.l_zoom.Name = "l_zoom";
            this.l_zoom.Size = new System.Drawing.Size(59, 20);
            this.l_zoom.TabIndex = 6;
            this.l_zoom.Text = "Zoom:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(476, 280);
            this.Controls.Add(this.l_zoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pb_zoom);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FColorManager";
            ((System.ComponentModel.ISupportInitialize)(this.pb_zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer t_zoom;
        private InterpolatingPictureBox pb_zoom;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l_r_hex;
        private System.Windows.Forms.Label l_r_rgb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_zoom;
    }
}

