using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ödevvvvv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<DateTime> takvim = new List<DateTime>();
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now.Date;

            foreach (DateTime tarih in takvim)
            {
                if (tarih == bugun)
                {
                    notifyIcon1.BalloonTipTitle = "Hatırlatma";
                    notifyIcon1.BalloonTipText = "Bugün " + tarih.ToShortDateString() + "!";
                    notifyIcon1.ShowBalloonTip(3000);
                }
            }
            saat.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.Visible = true;
            timer1.Start();
            dgvliste.Columns.Add("faturaadi", "Faturaadi");
            dgvliste.Columns.Add("tutar", "Tutar");
           dgvliste.Columns.Add("tarih", "Tarih");


        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string faturaadi = txtad.Text.Trim();
            string tutar = txttutar.Text.Trim();
            DateTime tarih = dtpSonOdeme.Value.Date;

            if (!string.IsNullOrWhiteSpace(faturaadi) && !string.IsNullOrWhiteSpace(tutar))
            {
                dgvliste.Rows.Add(faturaadi, tutar, tarih.ToShortDateString());
                takvim.Add(tarih);

                MessageBox.Show("Bilgiler başarıyla eklendi!", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtad.Clear();
                txttutar.Clear();
                dtpSonOdeme.Value = DateTime.Now;
            }

        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
