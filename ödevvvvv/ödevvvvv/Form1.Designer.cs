namespace ödevvvvv
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
            this.txtad = new System.Windows.Forms.TextBox();
            this.txttutar = new System.Windows.Forms.TextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.lbltutar = new System.Windows.Forms.Label();
            this.lbltarih = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.dtpSonOdeme = new System.Windows.Forms.DateTimePicker();
            this.saat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvliste = new System.Windows.Forms.DataGridView();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvliste)).BeginInit();
            this.SuspendLayout();
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(207, 54);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 1;
            // 
            // txttutar
            // 
            this.txttutar.Location = new System.Drawing.Point(207, 101);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(100, 20);
            this.txttutar.TabIndex = 2;
            this.txttutar.TextChanged += new System.EventHandler(this.txttutar_TextChanged);
            this.txttutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttutar_KeyPress);
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(35, 54);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(51, 13);
            this.lblad.TabIndex = 3;
            this.lblad.Text = "fatura adı";
            // 
            // lbltutar
            // 
            this.lbltutar.AutoSize = true;
            this.lbltutar.Location = new System.Drawing.Point(38, 101);
            this.lbltutar.Name = "lbltutar";
            this.lbltutar.Size = new System.Drawing.Size(28, 13);
            this.lbltutar.TabIndex = 4;
            this.lbltutar.Text = "tutar";
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Location = new System.Drawing.Point(34, 148);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(27, 13);
            this.lbltarih.TabIndex = 5;
            this.lbltarih.Text = "tarih";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(207, 197);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 6;
            this.btnekle.Text = "fatura ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // dtpSonOdeme
            // 
            this.dtpSonOdeme.Location = new System.Drawing.Point(207, 148);
            this.dtpSonOdeme.Name = "dtpSonOdeme";
            this.dtpSonOdeme.Size = new System.Drawing.Size(200, 20);
            this.dtpSonOdeme.TabIndex = 7;
            // 
            // saat
            // 
            this.saat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saat.Location = new System.Drawing.Point(0, 455);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(502, 13);
            this.saat.TabIndex = 8;
            this.saat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgvliste
            // 
            this.dgvliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvliste.Location = new System.Drawing.Point(12, 226);
            this.dgvliste.Name = "dgvliste";
            this.dgvliste.Size = new System.Drawing.Size(490, 242);
            this.dgvliste.TabIndex = 9;
            // 
            // btncıkıs
            // 
            this.btncıkıs.Location = new System.Drawing.Point(332, 197);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(75, 23);
            this.btncıkıs.TabIndex = 10;
            this.btncıkıs.Text = "çıkış";
            this.btncıkıs.UseVisualStyleBackColor = true;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 468);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.dgvliste);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.dtpSonOdeme);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.lbltutar);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.txttutar);
            this.Controls.Add(this.txtad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvliste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lbltutar;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DateTimePicker dtpSonOdeme;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvliste;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

