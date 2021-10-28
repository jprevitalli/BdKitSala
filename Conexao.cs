using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdKitSala
{
    class Conexao
    {
        static public string Conectar() 
        {

            return @"Data Source=DESKTOP-4QOUJ24\SQLEXPRESS;Initial Catalog=bdkitsala;Integrated Security=True";

        }

    }
}
