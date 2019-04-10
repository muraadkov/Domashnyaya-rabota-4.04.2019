using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DZ1
{
    public class StarWarsSwapiCo
    {
        public void StarWars()
        {
            List<People> peoples = new List<People>();
            WebClient webClient = new WebClient();
            string file = "file.xml";
            Console.WriteLine("Идентификатор персонажа: ");
            int id = int.Parse(Console.ReadLine());
            string jsonStr = webClient.DownloadString($"https://swapi.co/api/people/{id}");
            People newPerson = JsonConvert.DeserializeObject<People>(jsonStr);
            if (!People.Exist(peoples, newPerson))
            {
                WriteToFile(file, jsonStr);
                peoples.Add(newPerson);
                Console.WriteLine("Добавление в файл...");
                newPerson.Print();
            }
            void WriteToFile(string path, string jsonString)
            {
                XNode node = JsonConvert.DeserializeXNode(jsonString, "root");
                string xmlStr = node.ToString();
                XmlDocument xmlDocument = new XmlDocument();
                if (!File.Exists(path))
                {
                    using (FileStream fileStream = File.Create(path))
                    {
                        byte[] bytes = System.Text.Encoding.Default.GetBytes(xmlStr);
                        fileStream.Write(bytes, 0, bytes.Length);
                    }
                }
                else
                {
                    using (StreamWriter streamWriter = new StreamWriter(path, true))
                    {
                        streamWriter.Write(xmlStr);
                    }
                }
            }
        }
    }
}
