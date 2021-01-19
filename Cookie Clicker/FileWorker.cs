using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cookie_Clicker
{
    public class FileWorker
    {
        private readonly string _path;
        public FileWorker(string path)
        {
            _path = path;
        }

        public void SaveUnits(Dictionary<string,Unit> dictionary)
        {
            string output = JsonConvert.SerializeObject(dictionary);
            StreamWriter writer = new StreamWriter(_path);
            writer.WriteLine(output);
            writer.Close();
        }

        public Dictionary<string, Unit> LoadUnits()
        {
            StreamReader reader = new StreamReader(_path);
            string text = reader.ReadLine();
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, Unit>>(text);
            reader.Close();
            return dictionary;
        }
    }
}
