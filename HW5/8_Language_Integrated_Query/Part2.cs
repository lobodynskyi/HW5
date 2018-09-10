using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._8_Language_Integrated_Query
{
    class Part2
    {

        string[] array;
       
        public void FillDictionary()
        {
            List<string> list = new List<string>();
            try
            {

                string filePass = "C:\\Users\\Nazar\\source\\repos\\HW5\\HW5\\8_Language_Integrated_Query\\Text.txt";
                using (StreamReader sr = new StreamReader(filePass, System.Text.Encoding.Default))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            array = list.ToArray();
        }

        public void Present()
        {
            int i = 0;
            var zad1 = array.Select(x => x.Length).ToList();
            foreach (var e in zad1)
            {
                Console.WriteLine(i + " -> "+e );
                i++;
            }
            Console.WriteLine(zad1.Max() + " --" + zad1.Min());
            var zad2 = array.Where(x => x.Contains("var"));
            foreach (var e in zad2)
            {
                Console.WriteLine(e);
            }

        }

        public Part2()
        {
            FillDictionary();
            Present();
        }
    }
}
