using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EksperymentSłownikowy
{
    class Program
    {
        static void Ustaw<T>(ref Dictionary<T, int> keyValuePairs) where T : IUstaw, new()
        {
            for (int i = 0; i < 50000; i++)
            {
                T key = new();
                key.Key = i;
                keyValuePairs[key] = i;
            }
        }
        static void Test<T>() where T : IUstaw, new()
        {
            Dictionary<T, int> keyValuePairs = new();
            Ustaw(ref keyValuePairs);
            int niepowodzenia = 0;
            DateTime początek = DateTime.Now;
            for (int i = 0; i < 50000; i++)
            {
                T key = new();
                key.Key = i;
                if (!keyValuePairs.TryGetValue(key, out _)) niepowodzenia++;
            }
            TimeSpan koniec = DateTime.Now - początek;
            string wynik = koniec.ToString();
            Console.WriteLine(wynik+" niepowodzenia: "+niepowodzenia);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Test dla dobrego hashcode i klasy: ");
            Test<DictKey>();
            Console.WriteLine("Test dla złego hashcode i klasy: ");
            Test<ZłyClass>();
            Console.WriteLine("Test dla braku hashcode i klasy: ");
            Test<BrakClass>();
            Console.WriteLine("Test dla dobrego hashcode i struktury: ");
            Test<DictSKey>();
            Console.WriteLine("Test dla złego hashcode i struktury: ");
            Test<ZłyStruct>();
            Console.WriteLine("Test dla braku hashcode i struktury: ");
            Test<BrakStruct>();
        }
    }
}
