using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void LimparCheckBox() // rotina utilizada apenas para limpar
        {
            cbmassagem.Checked = false;
            cbdrenagem.Checked = false;
            cblifting.Checked = false;
            cbofuro.Checked = false;
        }

        private void txttarifa_TextChanged(object sender, EventArgs e)
        {
            if (txttarifa.Text == "")
                txttarifa.Text = 0.ToString();
            else
            {
                LimparCheckBox();
                txtfinal.Text = txttarifa.Text;
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            txtmassagem.Text = "150";
            txtdrenagem.Text = 120.ToString();
            txtlifting.Text = Convert.ToString(80);
            txtofuro.Text = 90 + "";

        }
      
        private void cbmassagem_CheckedChanged(object sender, EventArgs e)
        {
            if (cbmassagem.Checked==true)
                txtfinal.Text = (Convert.ToDecimal(txtfinal.Text) - Convert.ToDecimal(txtmassagem.Text)).ToString();
            else 
                txtfinal.Text = (Convert.ToDecimal(txtfinal.Text) + Convert.ToDecimal(txtmassagem.Text)).ToString(); 
        
        }
        private void cbdrenagem_CheckedChanged(object sender, EventArgs e)
        {
            if (cbdrenagem.Checked)
                txtfinal.Text = (Convert.ToDecimal(txtfinal.Text) - Convert.ToDecimal(txtdrenagem.Text)).ToString();
            else 
                txtfinal.Text = (Convert.ToDecimal(txtfinal.Text) + Convert.ToDecimal(txtdrenagem.Text)).ToString();

        }

        private void cblifting_CheckedChanged(object sender, EventArgs e)
        {
            if (cblifting.Checked)
                txtfinal.Text = (Convert.ToDecimal(txtfinal.Text) - Convert.ToDecimal(txtlifting.Text)).ToString();
            else 
                txtfinal.Text = (Convert.ToDecimal(txtfinal.Text) + Convert.ToDecimal(txtlifting.Text)).ToString();

        }
        private void cbofuro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbofuro.Checked)
                txtfinal.Text = (Convert.ToDecimal(txtfinal.Text) - Convert.ToDecimal(txtofuro.Text)).ToString();
            else 
                txtfinal.Text = (Convert.ToDecimal(txtfinal.Text) + Convert.ToDecimal(txtofuro.Text)).ToString();

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txttarifa.Text = 0.ToString();
            txtfinal.Text = 0.ToString();
            LimparCheckBox();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }
    } 
}
