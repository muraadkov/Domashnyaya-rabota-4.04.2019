using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    public class People
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("mass")]
        public string Mass { get; set; }

        [JsonProperty("hair_color")]
        public string HairColor { get; set; }

        [JsonProperty("skin_color")]
        public string SkinColor { get; set; }

        [JsonProperty("eye_color")]
        public string EyeColor { get; set; }

        [JsonProperty("birth_year")]
        public string BirthYear { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("homeworld")]
        public string Homeworld { get; set; }

        [JsonProperty("films")]
        public List<string> Films { get; set; }

        [JsonProperty("species")]
        public List<string> Species { get; set; }

        [JsonProperty("vehicles")]
        public List<string> Vehicles { get; set; }

        [JsonProperty("starships")]
        public List<string> Starships { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        static public bool Exist(List<People> peoples, People person)
        {
            foreach (var p in peoples)
            {
                if (p.Name == person.Name)
                {
                    return true;
                }
            }
            return false;
        }
        public void Print()
        {
            Console.WriteLine($"Имя : {Name}");
            Console.WriteLine($"Пол : {Gender}");
            Console.WriteLine($"Рост : {Height}");
            Console.WriteLine($"Вес  : {Mass}");
            Console.WriteLine($"Год рождения : {BirthYear}");
            Console.WriteLine($"Цвет волос : {HairColor}");
            Console.WriteLine($"Цвет кожи : {SkinColor}");
            Console.WriteLine($"Цвет глаз : {EyeColor}");
        }
    }
}
