
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

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor inválido");
            }

            Saldo += valor;
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

        public void Transferir(Conta destino, decimal valor)
        {
            if (destino == null)
            {
                throw new ArgumentNullException(nameof(destino));
            }

            if (valor <= 0)
            {
                throw new ArgumentException("Valor inválido");
            }

            if (Saldo < valor)
            {
                throw new Exception("Saldo insuficiente");
            }

            Sacar(valor);
            destino.Depositar(valor);
        }
    }
}
