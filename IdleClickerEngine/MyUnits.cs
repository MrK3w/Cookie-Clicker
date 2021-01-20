using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleClickerEngine
{
    public class MyUnits
    {
     
        public static Dictionary<string, Unit> UnitDictionary { get; private set; }
        
        //Prepare your dictionary on start of the program
        public static void InitiateDictionary(string path)
        {
            if (!File.Exists(path))
            {
                InitiateDictionaryWithoutFile();
            }
            else
            {
                InitiateDictionaryFromFile(path);
            }
        }

        /// <summary>
        /// Every second count your passive points
        /// </summary>
        /// <returns></returns>
        public static int GetDpsOfYourUnits()
        {
            int sum = 0;
            foreach (KeyValuePair<string, Unit> unit in UnitDictionary)
            {
                if (unit.Key == "basic unit")
                {
                    sum += unit.Value.CountOfUnit * unit.Value.DamageDealt;
                }

                if (unit.Key == "intermediate unit")
                {
                    sum += unit.Value.CountOfUnit * unit.Value.DamageDealt;
                }
            }

            return sum;
        }

        public static bool BuyBasicUnit()
        {
            return BuyUnit("basic unit");
        }

        public static bool BuyIntermediateUnit()
        {
            return BuyUnit("intermediate unit");
        }

        private static bool BuyUnit(string nameOfUnit)
        {
            if (MyInfo.Coins >= UnitDictionary[nameOfUnit].Price)
            {
                UnitDictionary[nameOfUnit].CountOfUnit += 1;
                MyInfo.Coins -= UnitDictionary[nameOfUnit].Price;
                return true;
            }

            return false;
        }




        /// <summary>
        /// Initiate dictionary from file
        /// </summary>
        private static void InitiateDictionaryWithoutFile()
        {
            UnitDictionary = new Dictionary<string, Unit>
            {
                {"basic unit", new Unit(0, TypeOfUnit.MeleePower, 10, 1)},
                {"intermediate unit", new Unit(0, TypeOfUnit.MagicalPower, 100, 1000000)},
            };
        }


        private static void InitiateDictionaryFromFile(string path)
        {
            FileWorker worker = new FileWorker(path);
            UnitDictionary = worker.LoadUnits();
        }
    }
}
