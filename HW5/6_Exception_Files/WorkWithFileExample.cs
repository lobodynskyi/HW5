using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW5._6_Exception_Files
{
    class WorkWithFileExample
    {
        string path1 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"6_Exception_Files\Data.txt");
        string path2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"6_Exception_Files\Rez1.txt");
        public  void TranserDataBetweenFiles()
        {
                WriteSteam("C:\\Users\\Nazar\\source\\repos\\HW5\\HW5\\6_Exception_Files\\Rez1.txt",
                    ReadSteam("C:\\Users\\Nazar\\source\\repos\\HW5\\HW5\\6_Exception_Files\\Data.txt"));

            ReadWriteAll("C:\\Users\\Nazar\\source\\repos\\HW5\\HW5\\6_Exception_Files\\Data.txt",
                "C:\\Users\\Nazar\\source\\repos\\HW5\\HW5\\6_Exception_Files\\Rez2.txt");
        }

        public string ReadSteam (string filePass)
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                using (StreamReader sr = new StreamReader(filePass, System.Text.Encoding.Default))
                {
                    String line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        stringBuilder.Append(line + "\n");
                    }
                }
                return stringBuilder.ToString();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return string.Empty;
        }

        public void WriteSteam(string filePass, string textToWrite)
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                using (StreamWriter sw = new StreamWriter(filePass, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(textToWrite);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }            
        }

        public void ReadWriteAll(string filePassFrom, string filePassTo)
        {
            try
            {
                string text = File.ReadAllText(filePassFrom, System.Text.Encoding.Default);
                File.WriteAllText(filePassTo, text, System.Text.Encoding.Default);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }

        
    }
}
