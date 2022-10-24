namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string number { get; set; }
        private string _model { get; set; }
        private string _imei { get; set; }
        private int _memory { get; set; }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            number = numero;
            _model = modelo;
            _imei = imei;
            _memory = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}