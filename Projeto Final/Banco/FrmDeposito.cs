using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FrmDeposito : Form
    {
        public List<Cliente> listaCliente = null;
        public FrmDeposito()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e) //RELÓGIO
        {
            lblInicio.Text = DateTime.Now.ToLongTimeString();
            lbldata.Text = DateTime.Now.ToShortDateString();
        }
        private void cmdValidarDeposito_Click(object sender, EventArgs e)
        {
            int aux = 0;
            foreach(var item in listaCliente)
            {   
                if(int.Parse(txtcontaDeposito.Text)== item.Conta)
                {
                    txtnomeDeposito.Text = item.Nome;
                    txtsobrenomeDeposito.Text = item.Sobrenome;
                    txtvalorDeposito.Enabled = true;
                    aux++;
                }
            }
            if(aux==0)
                MessageBox.Show("Conta inválida!");
        }
        private void cmdDeposito_Click(object sender, EventArgs e)
        {
            foreach (var item in listaCliente)
            {
                if (int.Parse(txtcontaDeposito.Text) == item.Conta)
                {
                    item.Saldo = item.Saldo + double.Parse(txtvalorDeposito.Text);
                    MessageBox.Show("Depósito realizado com sucesso!");
                }
            }
            foreach (Control item in panel1.Controls) // limpar campos
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void cmdVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
