using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Arguments.Plataforma;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServicePlataforma
    {

        AdicionarPlataformaReponse AdicionarPlataforma(AdicionarPlataformaRequest request);

    }
}
