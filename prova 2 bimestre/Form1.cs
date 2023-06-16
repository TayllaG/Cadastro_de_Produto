using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova_2_bimestre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb_valorVenda.Text = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string unidade = Convert.ToString(combobox_unidade.Text);
                double valor = Convert.ToDouble(tx_valor.Text);
                double pis = Convert.ToDouble(tx_pis.Text);
                double icms = Convert.ToDouble(tx_icms.Text);
                double confins = Convert.ToDouble(tx_confins.Text);
                double lucro = Convert.ToDouble(tx_lucro.Text);
                double valorVenda = Convert.ToDouble(lb_valorVenda.Text);

                Produto p = new Produto(unidade, valor, pis, icms, confins, lucro);

                lb_valorVenda.Text = p.CalcularValorF();
            }
            catch(Exception error) 
            { 
                MessageBox.Show(error.Message);
            }
        }

        
    }   
}
