using System;
using System.IO;
namespace ConsoleApp10
{
    internal class Program
    {
        static List<String> names = new List<string>();
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                names.Add("Sümeyra " + i.ToString());
            }
            NextPage(3);

            
            //String s = "Bu gün hava çok sıcak";
            //var x = s.Skip(3).Take(5);
            //Console.WriteLine(String.Join(";", x));
            //string[] names = new string[] { "Zara Ali", "Nuha Ali" };

            //using (StreamWriter sw = new StreamWriter("names.txt"))
            //{

            //    foreach (string s in names)
            //    {
            //        sw.WriteLine(s);
            //    }
            //}

            //// Read and show each line from the file.
            //string line = "";
            //using (StreamReader sr = new StreamReader("names.txt"))
            //{
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            //Console.ReadKey();
        }
        static bool NextPage(int pageIndex)
        {
            List<string> strings = names.Skip(pageIndex*10).Take(10).ToList();
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
            return pageIndex * 10 >= names.Count; //pageIndex kaçıncı onluğu istiyoruz demek.
        }
    }
}