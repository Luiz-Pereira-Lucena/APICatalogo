using APICatalogo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private static Dictionary<Guid, Jogo> jogos = new Dictionary<Guid, Jogo>()
        {
            {Guid.Parse("f709d8b2-0a60-42ce-93e1-03c314016416"), new Jogo{ Id = Guid.Parse("f709d8b2-0a60-42ce-93e1-03c314016416"), Nome = "FIFA 21", Produtora = "EA Sport", Preco = 200} },
            {Guid.Parse("296aa0c6-a957-4bfb-80e2-0a1071214d75"), new Jogo{ Id = Guid.Parse("296aa0c6-a957-4bfb-80e2-0a1071214d75"), Nome = "UEFA 21", Produtora = "LuizProdutor", Preco = 357} },
            {Guid.Parse("0d0102c5-8fea-4a4a-96c0-01b59496f620"), new Jogo{ Id = Guid.Parse("0d0102c5-8fea-4a4a-96c0-01b59496f620"), Nome = "CS GO", Produtora = "TesteProdutora", Preco = 607} },
            {Guid.Parse("9ca20428-c00e-429b-b5de-fe568bcb595d"), new Jogo{ Id = Guid.Parse("9ca20428-c00e-429b-b5de-fe568bcb595d"), Nome = "MMA 2022", Produtora = "Garena", Preco = 204} },
            {Guid.Parse("30fa6a19-1591-4473-8338-9c4e80c0eac5"), new Jogo{ Id = Guid.Parse("30fa6a19-1591-4473-8338-9c4e80c0eac5"), Nome = "FORMULA 1", Produtora = "TesteProdutora2", Preco = 396} },
            {Guid.Parse("b8585ce2-0bb5-486d-80aa-55ebacda1de0"), new Jogo{ Id = Guid.Parse("b8585ce2-0bb5-486d-80aa-55ebacda1de0"), Nome = "GTA V", Produtora = "RockStar", Preco = 599} },
        };

        public Task<List<Jogo>> Obter(int pagina, int quantidade)
        {
            return Task.FromResult(jogos.Values.Skip((pagina - 1) * quantidade).Take(quantidade).ToList());
        }

        public Task<Jogo> Obter(Guid id)
        {
            if (!jogos.ContainsKey(id))
                return null;

            return Task.FromResult(jogos[id]);
        }

        public Task<List<Jogo>> Obter(string nome, string produtora)
        {
            return Task.FromResult(jogos.Values.Where(jogo => jogo.Produtora.Equals(produtora)).ToList());
        }

        public Task<List<Jogo>> ObterSemLambda(string nome, string produtora)
        {
            var retorno = new List<Jogo>();

            foreach(var jogo in jogos.Values)
            {
                if (jogo.Nome.Equals(nome) && jogo.Produtora.Equals(produtora))
                    retorno.Add(jogo);
            }

            return Task.FromResult(retorno);
        }

        public Task Inserir(Jogo jogo)
        {
            jogos.Add(jogo.Id, jogo);
            return Task.CompletedTask;
        }

        public Task Atualizar(Jogo jogo)
        {
            jogos[jogo.Id] = jogo;
            return Task.CompletedTask;
        }

        public Task Remover(Guid id)
        {
            jogos.Remove(id);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            //Fechar conexão com o banco
            //No momento está tudo em memória
        }
    }
}
