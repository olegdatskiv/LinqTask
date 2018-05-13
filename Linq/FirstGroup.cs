using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Linq
{
    public class FirstGroup
    {
        private static List<int> IntParse(string path_file)
        {

            if (!File.Exists(path_file))
            {
                throw new InvalidCastException("Bad path");
            }
            string[] array = File.ReadAllText(path_file).ToString().Split(' ');
            int number;
            List<int> list = new List<int>();
            foreach (var it in array)
            {
                if (Int32.TryParse(it, out number))
                {
                    list.Add(number);
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} is not number", it));
                }
            }
            return list;
        }
        public static List<int> Task1(string path_file)
        {
            try
            {
                List<int> list = IntParse(path_file);
                var result = from it in list where it > 0 select it;
                return result.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                throw;
            }
        }

        public static List<int> Task2(string path_file)
        {
            try
            {
                List<int> list = IntParse(path_file);
                var result = (from it in list where it % 2 != 0 select it).Distinct();
                return result.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                throw;
            }
        }

        public static List<int> Task3(string path_file)
        {
            try
            {
                List<int> list = IntParse(path_file);
                var result = (from it in list where it / 100 == 0 && it / 10 != 0 select it).OrderBy(x => x);
                return result.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                throw;
            }
        }

        public static List<string> Task4(string path_file)
        {
            try
            {
                if (!File.Exists(path_file))
                {
                    throw new InvalidCastException("Bad path");
                }
                string[] array = File.ReadAllText(path_file).ToString().Split(' ');
                var result = array.OrderByDescending(x => x.Length).Reverse();
                return result.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                throw;
            }
        }

        public static List<int> Task5(string path_file)
        {
            try
            {
                List<int> list = IntParse(path_file);
                int number = list[0];
                list.RemoveAt(0);
                var result = list.SkipWhile(x => x <= number).Where(x => x % 2 != 0 && x > 0).Reverse();
                return result.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                throw;
            }
        }
    }
}
