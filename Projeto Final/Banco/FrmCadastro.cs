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
    public partial class FrmCadastro : Form
    {
        public List<Cliente> listaCliente = null;
        Cliente c = null;
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void cmdCadastroo_Click(object sender, EventArgs e)
        {
            int aux = 0;
            foreach (var item in listaCliente)
            {
                if (item.Conta == int.Parse(txtconta.Text))
                {
                    MessageBox.Show("OPS, conta já cadastrada!");
                    aux++;
                }
            }
            if (aux == 0)
            {
                c = new Cliente();
                c.Nome = txtNome.Text;
                c.Sobrenome = txtSobrenome.Text;
                c.Renda = double.Parse(txtRenda.Text);
                c.Conta = int.Parse(txtconta.Text);
                c.Senha = int.Parse(txtsenha.Text);
                listaCliente.Add(c);
                MessageBox.Show("Cadastrado realizado com sucesso!");
            }
            foreach (Control item in panel1.Controls) // limpar campos
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is RadioButton)
                {
                    RadioButton r = (RadioButton)item;
                    r.Checked = false;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e) //Relogio
        {
            lblInicio.Text = DateTime.Now.ToLongTimeString();
            lbldata.Text = DateTime.Now.ToShortDateString();
        }

        private void cmdVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
