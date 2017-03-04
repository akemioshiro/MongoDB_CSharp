using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listagem
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
                //var filtro = Builders<Usuario>.Filter.Empty;
                var filtro = Builders<Usuario>.Filter.Where(u=>u.Login=="walter");

                var usuarios = colecao.Find(filtro).ToList();

                usuarios.ForEach(u => Console.WriteLine(u));
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }

        }
    }
}
