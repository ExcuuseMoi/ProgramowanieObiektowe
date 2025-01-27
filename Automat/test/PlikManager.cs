using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class PlikManager
    {
        
        public void ZapiszDoPliku(string sciezka, List<string> dane)
        {
            File.WriteAllLines(sciezka, dane);
        }

        
        public List<string> WczytajZPliku(string sciezka)
        {
            if (File.Exists(sciezka))
            {
                return new List<string>(File.ReadAllLines(sciezka));
            }
            return new List<string>();
        }
    }
}
