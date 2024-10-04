namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        private string Modelo { get; set; }

        private string IMEI { get; set; }

        private int Memoria { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Console.WriteLine($"Modelo: {modelo} \n" +
                $"Numero: {numero} \n" +
                $"IMEI: {imei} \n" +
                $"Memoria: {memoria}");

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