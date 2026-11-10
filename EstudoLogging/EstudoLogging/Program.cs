
using System;
using NLog;
using EstudoLogging;

class Program
{
    private static readonly Logger logger =
        LogManager.GetCurrentClassLogger();

    static void Main(string[] args)
    {
        logger.Info("Aplicação iniciada");

        var conta1 = new Conta(1000);
        var conta2 = new Conta(500);

        try
        {
            // DEPÓSITO
            logger.Info("Iniciando depósito de 200");

            conta1.Depositar(200);

            logger.Info("Depósito realizado com sucesso");

            // SAQUE
            logger.Info("Iniciando saque de 100");

            conta1.Sacar(100);

            logger.Info("Saque realizado com sucesso");

            // TRANSFERÊNCIA
            logger.Info("Iniciando transferência de 300");

            conta1.Transferir(conta2, 300);

            logger.Info("Transferência realizada com sucesso");

            // SALDOS
            logger.Info(
                "Saldo final da conta 1: {0}",
                conta1.Saldo);

            logger.Info(
                "Saldo final da conta 2: {0}",
                conta2.Saldo);
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Erro durante operação bancária");
        }

        logger.Info("Aplicação finalizada");

        LogManager.Shutdown();
    }
}
