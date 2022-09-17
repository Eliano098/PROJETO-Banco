using System;
using System.CodeDom.Compiler;
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
    public partial class FrmConsulta : Form
    {
        public List<Cliente> listaCliente = null;
        public FrmConsulta()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e) //Relogio
        {
            lblInicio.Text = DateTime.Now.ToLongTimeString();
            lbldata.Text = DateTime.Now.ToShortDateString();
        }
        private void cmdValidarConsulta_Click(object sender, EventArgs e)
        {
            int aux = 0;
            foreach (var item in listaCliente)
            {
                if ((int.Parse(txtcontaConsulta.Text) == item.Conta) && (int.Parse(txtsenhaConsulta.Text) == item.Senha))
                {
                    MessageBox.Show("Seja bem vindo, " + item.Nome + "!");
                    listBox1.Items.Add("Nome " + item.Nome);
                    listBox1.Items.Add("Sobrenome: " + item.Sobrenome);
                    listBox1.Items.Add("N°conta: " + item.Conta);
                    listBox1.Items.Add("Saldo: R$" + item.Saldo.ToString("0.00"));
                    aux++;
                }
            }

            if (aux == 0)
            {
                MessageBox.Show("Conta inválida!");
            }
        }
        private void cmdVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdNovaConsulta_Click(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls) // limpar campos
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ListBox)
                {
                    listBox1.Items.Clear();
                }
            }
        }
    }
}
