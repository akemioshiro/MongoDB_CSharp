using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exclusao
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
                //var filtro = Builders<Usuario>.Filter.Eq(u => u.Login, "lara");
                var filtro = Builders<Usuario>.Filter.Where(u => u.Login == "lara" || u.Login == "juca");

                //var resultado = colecao.DeleteOne(filtro);
                var resultado = colecao.DeleteMany(filtro);
                Console.WriteLine($"{resultado.DeletedCount} documento(s) excluído(s).");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }

        }
    }
}
