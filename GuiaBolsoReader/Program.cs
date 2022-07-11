using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace GuiaBolsoReader
{
    class Program
    {
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddMilliseconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }

        public static string FormatUnix(double unixTime)
        {
            return UnixTimeStampToDateTime(unixTime).ToString("yyyy-MM-dd");
        }

        static void Main(string[] args)
        {
            var fileContent = File.ReadAllText(@"C:\Users\plane\Desktop\2022-06-guiabolso.json", System.Text.Encoding.UTF8);
            var deserializedContent = JsonConvert.DeserializeObject<Root>(fileContent);

            var categoryTypes = deserializedContent.Payload.RawData.CategoryTypes.SelectMany(g => g.Categories).ToDictionary(c => c.Id, c => c.Name);
            var items = deserializedContent.Payload
                                           .UserMonthHistory
                                           .Statements
                                           .SelectMany(s => s.Transactions.Select(t => $"{t.Id};\"{t.Label}\";{t.OriginalValue};{FormatUnix(t.Date)};{categoryTypes[t.CategoryId]}"))
                                           .ToList();

            File.WriteAllLines(@"C:\Users\plane\Desktop\2022-06-guiabolso.csv", items, System.Text.Encoding.UTF8);

            Console.WriteLine("Hello World!");
        }
    }
}
