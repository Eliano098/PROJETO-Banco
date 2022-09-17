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
    public partial class FrmTransferencia : Form
    {
        public List<Cliente> listaCliente = null;
        public FrmTransferencia()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e) //RELÓGIO
        {
            lblInicio.Text = DateTime.Now.ToLongTimeString();
            lbldata.Text = DateTime.Now.ToShortDateString();
        }
        private void cmdValidarTrans_Click(object sender, EventArgs e)
        {
            int aux = 0;
            foreach (var item in listaCliente)
            {
                if ((int.Parse(txtcontaTrans.Text) == item.Conta) && (int.Parse(txtsenhaTrans.Text) == item.Senha))
                {
                    MessageBox.Show("Olá, " + item.Nome + "!");
                    txtNomeTrans.Enabled = true;
                    txtcontaTrans2.Enabled = true;
                    txtValorTrans.Enabled = true;
                    aux++;
                }
            }
            if (aux == 0)
                MessageBox.Show("Conta inválida!");
        }
        private void txtcontaTrans2_Leave(object sender, EventArgs e)
        {
            int aux = 0;
            foreach (var item in listaCliente)
            {
                if (item.Conta == int.Parse(txtcontaTrans2.Text))
                {
                    txtNomeTrans.Text = item.Nome;
                    aux++;
                }
            }
            if (aux == 0)
            {
                txtNomeTrans.Text = "Conta inválida";
            }
        }

        private void cmdTransferencia_Click(object sender, EventArgs e)
        {
            int aux = 0;
            foreach (var item in listaCliente)
            {
                if (int.Parse(txtcontaTrans.Text) == item.Conta)
                {
                    item.Saldo = item.Saldo - double.Parse(txtValorTrans.Text);
                    foreach (var item2 in listaCliente)
                    {
                        if (int.Parse(txtcontaTrans2.Text) == item2.Conta)
                        {
                            aux++;
                            item2.Saldo = item2.Saldo + double.Parse(txtValorTrans.Text);
                            MessageBox.Show("Transferência realizada com sucesso!");
                        }
                    }
                }
            }

            if (aux == 0)
                MessageBox.Show("Conta inválida!");

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

        private void lblInicio_Click(object sender, EventArgs e)
        {

        }
    }
}
