using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Services;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando...");

            var service = new ServiceJogador();
            Console.WriteLine("Criei instancia do objeto");

            //AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            //Console.WriteLine("Criei instancia do meu objeto request");
            //request.Email = "paulo@paulo.com";
            //request.Senha = "12345678";

            var request = new AdicionarJogadorRequest() {
                Email = "Vinicius@vinicius.com",
                PrimeiroNome = "Vinicius",
                UltimoNome = "Nadalin",
                Senha = "123456"
            };

            var response = service.AdicionarJogador(request);

            Console.WriteLine("Serviço é valido -> " + service.IsValid());

            service.Notifications.ToList().ForEach(x =>
            {
                Console.Write(x.Message);
            });
            

            Console.ReadKey();
        }
    }
}
