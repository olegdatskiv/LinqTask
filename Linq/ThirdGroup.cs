using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace Linq
{
    public class ThirdGroup
    {
        private static List<Client> list = new List<Client>();

        private static void ParseClients(string path_file)
        {
            if (!File.Exists(path_file))
            {
                throw new InvalidCastException("Bad path");
            }

            string[] array = File.ReadAllText(path_file).ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach(var it in array)
            {
                string[] str = it.Split(' ');
                if(str.Length != 4)
                {
                    throw new ArgumentException(String.Format("Bad input data"));
                }
                int id = 0, year = 0, month = 0, duration = 0;
                if(!Int32.TryParse(str[0],out id) || !Int32.TryParse(str[1],out year)
                    || !Int32.TryParse(str[2],out month) || !Int32.TryParse(str[3],out duration))
                {
                    throw new ArgumentException(String.Format("Bad input data"));
                }
                var row_data = new Client(id, year, month, duration);
                list.Add(row_data);
            }
        }

        public static void Task(string path_file,string output_path_file)
        {
            ParseClients(path_file);
            var least_time_spend = LeastTimeSpent();
            var most_time_spent = MostTimeSpent();
            var year_when_most_total_time_spent = YearWhenMostTotalTimeSpent();
            var client = EachClientTotalTimeSpent().OrderBy(x=>x.DurationClasses).Reverse();
            var client2 = EachClientTotalMonths();
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(output_path_file))
            {
                file.WriteLine(least_time_spend.ToString());
                file.WriteLine(most_time_spent.ToString());
                file.WriteLine(year_when_most_total_time_spent.ToString());
                foreach(var it in client)
                {
                    file.WriteLine(it.ToString());
                }

                foreach (var it in client2)
                {
                    file.WriteLine(it.ToString());
                }

            }
        }

        private static int LeastTimeSpent()
        {
            var min = list.Min(x => x.DurationClasses);
            var result = list.Where(x => x.DurationClasses == min).First();
            return result.Id;
        }

        private static int MostTimeSpent()
        {
            var max = list.Max(x => x.DurationClasses);
            var result = list.Where(x => x.DurationClasses == max).First();
            return result.Id;
        }

        private static int YearWhenMostTotalTimeSpent()
        {
            var group_list = new List<Client>
            {
                list
                    .GroupBy(y => y.Year)
                    .Select(r => new Client
                    {
                        Year =  r.Key,
                        DurationClasses = r.Sum(s => s.DurationClasses)
                    })
                    .OrderByDescending(t => t.DurationClasses)
                    .ThenBy(y => y.Year)
                    .First()
            };
            var max = group_list.Max(x => x.DurationClasses);
            var result = group_list.Where(x => x.DurationClasses == max).First();
            return result.Year;
        }

        private static List<Client> EachClientTotalTimeSpent()
        {
            var result = list
                .GroupBy(y => y.Id)
                .Select(r => new Client
                {
                    Id = r.Key,
                    DurationClasses = r.Sum(s => s.DurationClasses)
                })
                .OrderByDescending(t => t.DurationClasses);
            return result.ToList();
        }

        private static List<Client> EachClientTotalMonths()
        {
            var result = list
                .GroupBy(y => y.Id)
                .Select(r => new Client
                {
                    Id = r.Key,
                    MonthNumber = r.Count()
                });

            return result.ToList();
        }
    }
}
