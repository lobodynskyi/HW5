using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._6_Exception_Files
{
  
    class HW6
    {
        public static void CheckNumer(int smallest, int biggest)
        {
            try
            {

                string filePass = "C:\\Users\\Nazar\\source\\repos\\HW5\\HW5\\6_Exception_Files\\Numbers.txt";
                using (StreamReader sr = new StreamReader(filePass, System.Text.Encoding.Default))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        try
                        {
                            int tmp = Int32.Parse(line);
                            if (tmp > smallest && tmp < biggest)
                                Console.WriteLine(tmp);
                            else
                                Console.WriteLine("Not in renge");
                        }
                        catch (Exception ee)
                        {
                            Console.WriteLine(ee.Message);
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        WorkWithFileExample example;
        PhoneBook phoneBook;
        public void IntroductionHW6()
        {
            //example = new WorkWithFileExample();
            //example.TranserDataBetweenFiles();
            //phoneBook = new PhoneBook();
            //phoneBook.FillDictionary();
            //phoneBook.Show();
            //Console.WriteLine("Find Olena Number = "  + phoneBook.Find("Olena"));
            //phoneBook.FillFileWithPhoneNumbers("C:\\Users\\Nazar\\source\\repos\\HW5\\HW5\\6_Exception_Files\\Phones1.txt");
            //phoneBook.ChangeFormat("C:\\Users\\Nazar\\source\\repos\\HW5\\HW5\\6_Exception_Files\\New.txt");
            CheckNumer(-2, 10);
        }
    }
}
