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
    public partial class FrmEmprestimo : Form
    {
        public List<Cliente> listaCliente = null;
        double aux = 0; // var para pegar o valor do emprestimo
        public FrmEmprestimo()
        {
            InitializeComponent();
        }

        // Classe não utilizada
        private void FrmEmprestimo_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Prezados clientes,\n" + "Todos os nossos empréstimos, são liberados conforme sua renda e saldo bancário não negativado. \n" +"\n"+ "A taxa de empréstimo é patrão para todos os valores, 10% do valor do empréstimo.";
        }

        private void cmdValidarEmprestimo_Click(object sender, EventArgs e)
        {
            int aux = 0;
            foreach (var item in listaCliente)
            {

                if ((int.Parse(txtcontaEmprestimo.Text) == item.Conta) && (int.Parse(txtsenhaEmprestimo.Text) == item.Senha))
                {
                    MessageBox.Show("Olá, " + item.Nome + "!");
                    groupBox1.Enabled = true;
                    aux++;
                }
            }
            if (aux == 0)
                MessageBox.Show("Conta inválida!");
        }

        private void cmdEmprestimo_Click(object sender, EventArgs e)
        {
            int aux1 = 0;
            foreach( RadioButton item in groupBox1.Controls) // verifica qual valor do emprestimo
            {
                if(item.Checked==true)
                {
                    aux = double.Parse(item.Text);
                }
            }

            foreach(var item in listaCliente) // verifica renda
            {
                
                if ((int.Parse(txtcontaEmprestimo.Text) == item.Conta))
                {
                    if ((item.Renda > (aux / 10)) && (item.Saldo >= 0))
                    {
                        MessageBox.Show("PARABÉNS, seu empréstimo foi aprovado!!!");
                        item.Emp =+ aux;
                        item.Saldo += item.Emp;
                        aux1++;
                    }
                }
            }
            if(aux1==0)
                MessageBox.Show("LAMENTAMOS, seu empréstimo foi negado!!!");

            foreach (Control item in panel1.Controls) // limpar campos
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach(RadioButton item in groupBox1.Controls)
            {
                    RadioButton r = (RadioButton)item;
                    r.Checked = false;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
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
