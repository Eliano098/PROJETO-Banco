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
    public partial class FrmPrincipal : Form
    {
        
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        List<Cliente> lista = new List<Cliente>();
        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro C = new FrmCadastro();
            C.listaCliente = lista;
            C.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta CO = new FrmConsulta();
            CO.listaCliente = lista;
            CO.ShowDialog();
        }

        private void trasnfênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransferencia T = new FrmTransferencia();
            T.listaCliente = lista;
            T.ShowDialog();
        }

        public void saqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSaque S = new FrmSaque();
            S.listaCliente = lista;
            S.ShowDialog();
        }

        private void depósitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeposito D = new FrmDeposito();
            D.listaCliente = lista;
            D.ShowDialog();
        }

        private void empréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmprestimo E = new FrmEmprestimo();
            E.listaCliente = lista;
            E.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdm A = new FrmAdm();
            A.listaCliente = lista;
            A.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmFim F = new FrmFim();
            F.ShowDialog();
        }
    }
}
