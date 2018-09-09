using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._6_Exception_Files
{
    class PhoneBook
    {
        Dictionary<string,string> phoneBook;

        public PhoneBook( )
        {
            phoneBook = new Dictionary<string, string>();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Show()
        {
            foreach (KeyValuePair<string, string> e in phoneBook)
            {
                Console.WriteLine(e.Key + "\t" + e.Value);
            }

        }

        public string Find(string name)
        {
            string answer;
            if (phoneBook.TryGetValue(name, out answer))
            {
                return answer;
            }
            return string.Empty;
        }

        public void FillFileWithPhoneNumbers(string filePass)
        {
            ICollection<string> numbers = phoneBook.Values;
            string text = string.Empty;
            try
            {
                foreach(var e in numbers)
                {
                    text = text + e + "\n";
                }

                File.WriteAllText(filePass, text, System.Text.Encoding.Default);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ChangeFormat(string filePass)
        {
            string text = string.Empty;
            foreach (KeyValuePair<string, string> e in phoneBook)
            {
              
                if(e.Value.StartsWith("+") != true)
                {
                    text = text + "+3" + e.Value + "\n";
                }
                else
                {
                    text = text  + e.Value + "\n";
                }
            }

            File.WriteAllText(filePass, text, System.Text.Encoding.Default);

        }
        public void FillDictionary()
        {
            try
            {

                string filePass = "C:\\Users\\Nazar\\source\\repos\\HW5\\HW5\\6_Exception_Files\\phones.txt";
                using (StreamReader sr = new StreamReader(filePass, System.Text.Encoding.Default))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] text = line.Split(',');
                        phoneBook.Add(text[0], text[1]);
                    }
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message );
            }
        }
    }
}
