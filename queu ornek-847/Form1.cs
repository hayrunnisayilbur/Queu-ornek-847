using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queu_ornek_847
{
    public partial class Form1 : Form
    {
        Stack< string>musteri=new Stack< string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            musteri.Push(txtAd.Text);
        }

         private void musteriCagir(Label lbl)
        {
            if (musteri.Count > 0)
            {
                label1.Text = musteri.Pop();
            }
            else
            {
                MessageBox.Show("işini hızlı bitirdin...");
            }
        }
            

private void Form1_Load(object sender, EventArgs e)
        {
            musteri.Push("hayrunnisa");
            musteri.Push("kübra");
            musteri.Push("sukeyna");
            musteri.Push("rabia");

        }

        private void btnCagir1_Click(object sender, EventArgs e)
        {
            musteriCagir(lblCagir2);
        }

        private void btnCagir2_Click(object sender, EventArgs e)
        {
            musteriCagir(lblCagir3);

        }

        private void btnCagir3_Click(object sender, EventArgs e)
        {
            musteriCagir(lblCagir4);

        }
    }
}