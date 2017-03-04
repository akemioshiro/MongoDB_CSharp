using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlteracaoComPropriedadeNova
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("loja");
                var colecao = database.GetCollection<Usuario>("usuarios");
                var filtro = Builders<Usuario>.Filter.Empty;
                var alteracao = Builders<Usuario>.Update.Set(u => u.Ativo, false);
                colecao.UpdateMany(filtro, alteracao);

                Console.WriteLine("Documento atualizado com sucesso.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }

        }
    }
}
