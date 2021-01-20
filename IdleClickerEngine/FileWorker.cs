using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace IdleClickerEngine
{
    public class FileWorker
    {
        private readonly string _path;
        public FileWorker(string path)
        {
            _path = path;
        }

        public void SaveUnits()
        {
            string output = JsonConvert.SerializeObject(MyUnits.UnitDictionary);
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
