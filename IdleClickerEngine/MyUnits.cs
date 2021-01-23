using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
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
        public static BigInteger GetDpsOfYourUnits()
        {
            BigInteger sum = 0;
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

                if (unit.Key == "hard unit")
                {
                    sum += unit.Value.CountOfUnit * unit.Value.DamageDealt;
                }

                if (unit.Key == "extreme unit")
                {
                    sum += unit.Value.CountOfUnit * unit.Value.DamageDealt;
                }
            }

            return sum;
        }

        public static bool NewUnit(string unit, int count = default)
        {
            return BuyUnit(unit, count);
        }


        private static bool BuyUnit(string nameOfUnit, BigInteger count)
        {
            if(count == default) count = MyInfo.Coins / UnitDictionary[nameOfUnit].Price;
            if (MyInfo.Coins < UnitDictionary[nameOfUnit].Price * count) return false;
            UnitDictionary[nameOfUnit].CountOfUnit += count;
            MyInfo.Coins -= UnitDictionary[nameOfUnit].Price * count;
            return true;

        }

        /// <summary>
        /// Initiate dictionary from file
        /// </summary>
        private static void InitiateDictionaryWithoutFile()
        {
            UnitDictionary = new Dictionary<string, Unit>
            {
                {"basic unit", new Unit(0, TypeOfUnit.MeleePower, 1, 10)},
                {"intermediate unit", new Unit(0, TypeOfUnit.MagicalPower, 10, 1000)},
                {"hard unit", new Unit(0, TypeOfUnit.MagicalPower, 100, 10000)},
                {"extreme unit", new Unit(0, TypeOfUnit.RangePower, 1000, 1000000)},
            };
        }


        private static void InitiateDictionaryFromFile(string path)
        {
            FileWorker worker = new FileWorker(path);
            UnitDictionary = worker.LoadUnits();
        }
    }
}
