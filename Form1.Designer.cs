namespace WinFormSnakeGame
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel = new System.Windows.Forms.Panel();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureDown = new System.Windows.Forms.PictureBox();
            this.pictureRight = new System.Windows.Forms.PictureBox();
            this.pictureUp = new System.Windows.Forms.PictureBox();
            this.pictureLeft = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(420, 420);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBaslat.FlatAppearance.BorderSize = 0;
            this.btnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaslat.Location = new System.Drawing.Point(444, 27);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(74, 32);
            this.btnBaslat.TabIndex = 2;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDurdur.FlatAppearance.BorderSize = 0;
            this.btnDurdur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDurdur.Location = new System.Drawing.Point(520, 27);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(74, 32);
            this.btnDurdur.TabIndex = 3;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = false;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnYeniOyun.FlatAppearance.BorderSize = 0;
            this.btnYeniOyun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeniOyun.Location = new System.Drawing.Point(444, 65);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(150, 32);
            this.btnYeniOyun.TabIndex = 4;
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Menu;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.pictureDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureRight, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureUp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureLeft, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(444, 138);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 150);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureDown
            // 
            this.pictureDown.Image = ((System.Drawing.Image)(resources.GetObject("pictureDown.Image")));
            this.pictureDown.Location = new System.Drawing.Point(52, 101);
            this.pictureDown.Name = "pictureDown";
            this.pictureDown.Size = new System.Drawing.Size(44, 44);
            this.pictureDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDown.TabIndex = 2;
            this.pictureDown.TabStop = false;
            this.pictureDown.Click += new System.EventHandler(this.pictureDown_Click);
            // 
            // pictureRight
            // 
            this.pictureRight.Image = ((System.Drawing.Image)(resources.GetObject("pictureRight.Image")));
            this.pictureRight.Location = new System.Drawing.Point(102, 52);
            this.pictureRight.Name = "pictureRight";
            this.pictureRight.Size = new System.Drawing.Size(45, 43);
            this.pictureRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRight.TabIndex = 3;
            this.pictureRight.TabStop = false;
            this.pictureRight.Click += new System.EventHandler(this.pictureRight_Click);
            // 
            // pictureUp
            // 
            this.pictureUp.Image = ((System.Drawing.Image)(resources.GetObject("pictureUp.Image")));
            this.pictureUp.Location = new System.Drawing.Point(52, 3);
            this.pictureUp.Name = "pictureUp";
            this.pictureUp.Size = new System.Drawing.Size(44, 43);
            this.pictureUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUp.TabIndex = 0;
            this.pictureUp.TabStop = false;
            this.pictureUp.Click += new System.EventHandler(this.pictureUp_Click);
            // 
            // pictureLeft
            // 
            this.pictureLeft.Image = ((System.Drawing.Image)(resources.GetObject("pictureLeft.Image")));
            this.pictureLeft.Location = new System.Drawing.Point(3, 52);
            this.pictureLeft.Name = "pictureLeft";
            this.pictureLeft.Size = new System.Drawing.Size(43, 43);
            this.pictureLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLeft.TabIndex = 1;
            this.pictureLeft.TabStop = false;
            this.pictureLeft.Click += new System.EventHandler(this.pictureLeft_Click);
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.SeaGreen;
            this.lblScore.Location = new System.Drawing.Point(441, 405);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(153, 27);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureUp;
        private System.Windows.Forms.PictureBox pictureLeft;
        private System.Windows.Forms.PictureBox pictureDown;
        private System.Windows.Forms.PictureBox pictureRight;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timer;
    }
}

