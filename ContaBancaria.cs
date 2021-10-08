using System.Globalization;

namespace Exercicio_Conta_Bancaria {
    class ContaBancaria {

        private double _numero { get; }
        private string _titular { get; }
        private double _quantia { get; set; }

        public ContaBancaria(double numero, string titular) {
            _numero = numero;
            _titular = titular;
        }  
            
        public void Deposito(double quantia) {
            _quantia += quantia;
        }

        public void Saque(double quantia) {
            _quantia -= quantia;
            _quantia = _quantia - 5;
        }

        public override string ToString() {
            return "Conta: " + _numero + "," + " Titular: " + _titular + ", " + "Saldo " + _quantia.ToString("F2", CultureInfo.InvariantCulture) + " R$" ;
        }
    }

}
