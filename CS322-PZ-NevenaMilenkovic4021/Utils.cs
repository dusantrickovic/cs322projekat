using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_PZ_NevenaMilenkovic4021
{
    public class Utils
    {
        public static string ReadJson()
        {
            using (StreamReader r = new StreamReader("./names.json"))
            {
                string json = r.ReadToEnd();
                List<String> names = JsonConvert.DeserializeObject<List<string>>(json);

                var random = new Random();
                int nasumicno = random.Next(names.Count);

                return names[nasumicno];
            }
        }

        public static void ReadFile(string path, ListBox lb)
        {
            int br = 0;

            foreach (string intro in System.IO.File.ReadLines(path))
            {
                lb.Items.Add(intro);
                br++;
            }
        }
    }
}
