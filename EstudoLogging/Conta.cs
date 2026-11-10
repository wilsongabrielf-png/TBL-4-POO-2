
using System;

namespace EstudoLogging
{
    public class Conta
    {
        public decimal Saldo { get; private set; }

        public Conta(decimal saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor inválido");
            }

            if (Saldo < valor)
            {
                throw new Exception("Saldo insuficiente");
            }

            Saldo -= valor;
        }
    }
}
