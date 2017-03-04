using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB_CSharp
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

                #region Alteração

                var filtro = Builders<Usuario>.Filter.Eq(u => u.Login, "lara");
                var alteracao = Builders<Usuario>.Update.Set(u => u.Senha, "senhanova");
                colecao.UpdateOne(filtro, alteracao);
                Console.WriteLine("Documento alterado com sucesso.");

                #endregion






            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }


        }
    }
}
