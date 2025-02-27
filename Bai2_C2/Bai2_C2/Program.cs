using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_C2
{
    class Program
    {
        enum Animal_224
        {
            Cat,
            Dog,
            Mokey,
            Bird,
            Fish,
            Tuna
        }
        static void Main(string[] args)
        {
          
            Console.WriteLine(Enum.GetName(typeof(Animal_224),4));

            foreach (var str in Enum.GetNames(typeof(Animal_224)))
            {
                Console.WriteLine(str);
            }

            Animal_224 anm_224;
            Enum.TryParse<Animal_224>("2",out anm_224);
            Console.WriteLine(anm_224);
            Console.ReadKey();
        }
    }
}
