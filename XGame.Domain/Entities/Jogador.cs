using prmToolkit.NotificationPattern;
using System;
using XGame.Domain.Extensions;
using XGame.Domain.ValueObjects;

namespace XGame.Domain
{
    public class Jogador : Notifiable
    {        
        public Guid Id { get; private set; }
        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public String Senha { get; private set; }
        public EnumSituacaoJogador Status { get; private set; }

        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this).IfNullOrEmptyOrInvalidLength(x=> x.Senha, 6, 32, "A senha deve ter entre 6 a 32 letras");

        }

        public Jogador(Nome nome, Email email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Id = Guid.NewGuid();
            Status = EnumSituacaoJogador.EmAnalise;

            new AddNotifications<Jogador>(this).IfNullOrInvalidLength(X => X.Senha, 6, 32);

            if (IsValid())
            {            
            Senha = Senha.ConvertToMD5();
            }

            AddNotifications(nome, email);
        }
    }
}
