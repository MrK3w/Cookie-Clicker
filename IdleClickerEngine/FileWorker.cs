using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace IdleClickerEngine
{
    public class FileWorker
    {
        private readonly string _path;
        
        private readonly MyUnits _units = MyUnits.GetInstance();

        public FileWorker(string path)
        {
            _path = path;
        }

        /// <summary>
        /// Save your units to txt
        /// </summary>
        public void SaveUnits()
        {
            string output = JsonConvert.SerializeObject(_units.UnitDictionary);
            StreamWriter writer = new StreamWriter(_path);
            writer.WriteLine(output);
            writer.Close();
        }
       
        /// <summary>
        /// Read txt and load dictionary
        /// </summary>
        /// <returns></returns>
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
