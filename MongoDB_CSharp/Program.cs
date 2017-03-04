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

                #region Insercao

                // inserindo um usuario
                var usuario = new Usuario {
                    Login = "juca",
                    Senha = "123456"
                };
                colecao.InsertOne(usuario);
                Console.WriteLine("Documento inserido com sucesso.");

                // inserindo mais de um usuario
                var usuarios = new List<Usuario>
                {
                    new Usuario() { Login="walter", Senha="4566" },
                    new Usuario() { Login="lara", Senha="qazwws"}
                };
                colecao.InsertMany(usuarios);
                Console.WriteLine("Documentos inseridos com sucesso.");

                #endregion

                




            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }


        }
    }
}
