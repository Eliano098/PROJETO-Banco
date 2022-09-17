using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Cliente
    {
        string nome, sobrenome;
        int conta, senha;
        double saldo=0;
        double renda = 0;
        double emp = 0;

        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public int Conta { get => conta; set => conta = value; }
        public int Senha { get => senha; set => senha = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public double Renda { get => renda; set => renda = value; }
        public double Emp { get => emp; set => emp = value; }
    }
}
