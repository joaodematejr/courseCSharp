using System;

namespace Curso
{
    class ContaBancaria
    {
        public string Titular {get; set}
        public double _saldo;

        public void Deposito(double quantia)
        {
            _saldo += quantia;
        }
        public double GetSaldo()
        {
            return _saldo;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo");
        }
    }
}
