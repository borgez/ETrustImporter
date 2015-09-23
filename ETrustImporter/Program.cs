using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_trust;

namespace ETrustImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = new ETrust();
            e.WriteIntermediates();
            Console.WriteLine("Импортировали всего {0}", e.total);
        }
    }
}
