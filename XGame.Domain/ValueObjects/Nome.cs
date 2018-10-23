using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.Domain.ValueObjects
{
    public class Nome : Notifiable
    {
        public Nome(string primeiroNome, string segundoNome)
        {
            PrimeiroNome = primeiroNome;
            SegundoNome = segundoNome;

            new AddNotifications<Nome>(this).IfNullOrEmptyOrInvalidLength(x => x.PrimeiroNome, 3, 50, string.Format("{0} é inválido", "Primeiro Nome"))
                                            .IfNullOrEmptyOrInvalidLength(x => x.SegundoNome, 3, 50, string.Format("{0} é inválido", "Segundo Nome"));
        }

        public String PrimeiroNome{get; private set;}
        public String SegundoNome { get; private set; }
    }
}
