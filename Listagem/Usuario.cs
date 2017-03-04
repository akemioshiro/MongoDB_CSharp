using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listagem
{
    public class Usuario
    {
        public ObjectId _id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        public override string ToString()
        {
            return $"Usuário: {Login} | Status: {(Ativo ? " Ativo" : " Inativo")}";
        }
    }
}
