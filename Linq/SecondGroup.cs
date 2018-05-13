using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Linq
{
    public class SecondGroup
    {
        public static List<int> Task1(string path_file)
        {
            if (!File.Exists(path_file))
            {
                throw new InvalidCastException("Bad path");
            }
        
            string[] array = File.ReadAllText(path_file).ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            int numberA = 0, numberB = 0;
            if(!Int32.TryParse(array[0],out numberA) || !Int32.TryParse(array[1],out numberB))
            {
                throw new ArgumentException(String.Format("not number"));
            }
            int value = 0;
            var list1 = array[2].Split(' ').Where(x => Int32.TryParse(x, out value)).Select(x => value).ToList();
            var list2 = array[3].Split(' ').Where(x => Int32.TryParse(x, out value)).Select(x => value).ToList();
            var list3 = (list1.Where(x => x > numberA).Concat(list2.Where(x => x < numberB)).OrderBy(x => x)).ToList();
            return list3.ToList();
        }

        public static List<string> Task2(string path_file)
        {
            if (!File.Exists(path_file))
            {
                throw new InvalidCastException("Bad path");
            }

            string[] array = File.ReadAllText(path_file).ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            int numberA = 0, numberB = 0;
            if (!Int32.TryParse(array[0], out numberA) || !Int32.TryParse(array[1], out numberB))
            {
                throw new ArgumentException(String.Format("not number"));
            }
            var list1 = array[2].Split(' ');
            var list2 = array[3].Split(' ');
            var list3 = list1.Where(x => x.Length == numberA).Concat(list2.Where(x => x.Length == numberB)).OrderBy(x => x).Reverse();
            return list3.ToList();
        }
    }
}
