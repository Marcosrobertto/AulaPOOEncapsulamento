namespace Encapsulamento.Classes
{
    public class Cartao
    {
        private string numero;
        public string Numero{
            get{return numero;} 
            set{numero = value;}
        }
        private string nomeTitular;
        public string NomeTitular{get;set;}
        private string bandeira;
        public string Bandeira{get;set;}
        protected string token = "qwertyui";
        public string Token{
            get{return token;}
        }
        private string cvv;
        public string Cvv{get;set;}
        protected float limite = 5000;
        public float Limite{get;set;}

        // Métodos

        public string RegistrarCompra(bool valido){
            return "";
        }

    }
}