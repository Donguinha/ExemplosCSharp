using UsandoInterface.Services;

namespace UsandoInterface.Entities
{
    internal class Conta 
    {
        private IOperacao _operacao;

        public Conta(IOperacao _operacao)
        {
            this._operacao = _operacao;
        }

        public double ChamarOperacao(double numero1, double numero2)
        {
            var result = _operacao.Operacao(numero1, numero2);
            return result;
        }
    }
}
