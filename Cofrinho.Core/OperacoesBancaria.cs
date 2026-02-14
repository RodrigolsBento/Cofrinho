using System.ComponentModel.DataAnnotations;

namespace Cofrinho.Core
{
    public class OperacoesBancaria
    {
        private static decimal _saldo;
       
        

        public static void Depositar (decimal valor)
        {
            _saldo += valor;
            
        }

        public static void Sacar(decimal valor)
        {

            if (valor > _saldo)
            {
                throw new Exception("E seu porra, ta sem saldo");
            }
            else
            {
                _saldo -= valor;

            }

        }

    }
}
