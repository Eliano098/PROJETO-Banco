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
    public partial class FrmSaque : Form
    {
        public List<Cliente> listaCliente = null;
        public FrmSaque()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)//RELÓGIO
        {
            lblInicio.Text = DateTime.Now.ToLongTimeString();
            lbldata.Text = DateTime.Now.ToShortDateString();
        }

        private void cmdValidar_Click(object sender, EventArgs e)
        {
            int aux = 0;
            foreach (var item in listaCliente)
            {
               
                if ((int.Parse(txtcontaSaque.Text) == item.Conta) && (int.Parse(txtsenhaSaque.Text) == item.Senha))
                {
                    MessageBox.Show("Olá, " + item.Nome + "!");
                    txtvalorSaque.Enabled = true;
                    aux++;
                }
            }
            if (aux == 0)
                MessageBox.Show("Conta inválida!");
        }

        private void cmdSaque_Click(object sender, EventArgs e)
        {
            foreach (var item in listaCliente)
            {
                if(int.Parse(txtcontaSaque.Text) == item.Conta)
                {
                    item.Saldo = item.Saldo - double.Parse(txtvalorSaque.Text);
                    MessageBox.Show("Saque realizado com sucesso!");
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
