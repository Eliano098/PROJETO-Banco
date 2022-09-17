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
    public partial class FrmAdm : Form
    {
        public List<Cliente> listaCliente = null;
        int i = 0;
        public double auxempre;
        public FrmAdm()
        {
            InitializeComponent();
            
        }
        private void cmdValidarAdm_Click(object sender, EventArgs e)
        {
            if((txtlogin.Text == "admin")&&(txtsenha.Text == "2312"))
                MessageBox.Show("Olá, bem vindo Sr.Eliano!"); 
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
                txtlogin.Text = "";
                txtsenha.Text = "";
            }   

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblInicio.Text = DateTime.Now.ToLongTimeString();
            lbldata.Text = DateTime.Now.ToShortDateString();
        }
        private void cmdAdm_Click(object sender, EventArgs e)
        {
            foreach(var item in listaCliente)
            {
                i++;
                auxempre =+ item.Emp;
            }
            txtlucromensalidade.Text = (i * 25).ToString(); // calculo mensalidade
            txtlucroemprestimo.Text = (auxempre / 10).ToString();
        }
        private void cmdVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAdm_Load(object sender, EventArgs e)
        {

        }
    }
}
