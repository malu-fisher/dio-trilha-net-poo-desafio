
namespace dio_trilha_net_poo_desafio.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"

         public Iphone(string numero, string modelo, string marca, string imei, int memoria)
            : base(numero, modelo, marca, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no iPhone.");
        }

    }
}