using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Lab2_databases {
    class RandomPackageClass {
        public int Previous { get; set; } = 0;

        public int[] RandomNumber(int min, int max, int count) {
            Random random = new Random(DateTime.Now.Ticks.GetHashCode() + Previous);
            int[] res = new int[count];
            for (int i = 0; i < count; i++) {
                int number = random.Next(min, max);
                if (!res.Contains(number)) //If it's not contains, add number to array;
                    res[i] = number;
                else 
                    i--;
                Previous = number;
            }
            return res;    
        }

        public string RandomString() {
            Random random = new Random(DateTime.Now.Ticks.GetHashCode() + Previous++);
            int[] length = RandomNumber(3, 50, 1);
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length[0])
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string RandomStringPhone() {
            Random random = new Random(DateTime.Now.Ticks.GetHashCode() + Previous++);
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, 11)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        /*names*/
        class NameList {
            public string[] boys { get; set; }
            public string[] girls { get; set; }
            public string[] last { get; set; }

            public NameList() {
                boys = new string[] { };
                girls = new string[] { };
                last = new string[] { };
            }
        }
        Random rand;
        List<string> Male;
        List<string> Female;
        List<string> Last;

        public RandomPackageClass() {
            rand = new Random(DateTime.Now.Ticks.GetHashCode());
            NameList l = new NameList();

            JsonSerializer serializer = new JsonSerializer();

            using (StreamReader reader = new StreamReader("names.json"))
            using (JsonReader jreader = new JsonTextReader(reader)) {
                l = serializer.Deserialize<NameList>(jreader);
            }

            Male = new List<string>(l.boys);
            Female = new List<string>(l.girls);
            Last = new List<string>(l.last);
        }

        public List<string> getSurnames() {
            return Last;
        }

        public List<string> getMalesNames() {
            return Male;
        }

        public List<string> getFemalesNames() {
            return Female;
        }

        public int getRandomNumberFromArray(List<int> l) {
            int[] res = RandomNumber(0, l.Count - 1, 1);
            return l[res[0]];
        }

        public bool getRandomBoolean() {
            int[] arr = RandomNumber(0, 3, 1);
            Console.WriteLine(arr[0]);
            if (arr[0] == 1) return true;
            return false;
        }

        public string getRandomFutureDate() {
            Random gen = new Random();
            int range = 2 * 365;
            DateTime randomDate = DateTime.Today.AddDays(gen.Next(range));
            return randomDate.ToString("dd.MM.yyyy");
        }

        public string getRandomPastDate() {
            Random gen = new Random();
            int range = 1 * 365;          
            DateTime randomDate = DateTime.Today.AddDays(-gen.Next(range));
            return randomDate.ToString("dd.MM.yyyy");
        }
    }
}
