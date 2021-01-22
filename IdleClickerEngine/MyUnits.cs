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

        public static bool BuyBasicUnit(int count)
        {
            return BuyUnit("basic unit",count);
        }

        public static bool BuyBasicUnit()
        {
            return BuyAllUnit("basic unit");
        }

        public static bool BuyIntermediateUnit(int count)
        {
            return BuyUnit("intermediate unit",count);
        }

        public static bool BuyIntermediateUnit()
        {
            return BuyAllUnit("intermediate unit");
        }

        public static bool BuyHardUnit(int count)
        {
            return BuyUnit("hard unit", count);
        }

        public static bool BuyHardUnit()
        {
            return BuyAllUnit("hard unit");
        }

        public static bool BuyExtremeUnit(int count)
        {
            return BuyUnit("extreme unit", count);
        }

        public static bool BuyExtremeUnit()
        {
            return BuyAllUnit("extreme unit");
        }

        private static bool BuyUnit(string nameOfUnit, BigInteger count)
        {
            if (MyInfo.Coins >= UnitDictionary[nameOfUnit].Price*count)
            {
                UnitDictionary[nameOfUnit].CountOfUnit += count;
                MyInfo.Coins -= UnitDictionary[nameOfUnit].Price * count;
                return true;
            }

            return false;
        }

        private static bool BuyAllUnit(string nameOfUnit)
        {
            BigInteger count = MyInfo.Coins / UnitDictionary[nameOfUnit].Price;
            if (MyInfo.Coins >= UnitDictionary[nameOfUnit].Price * count)
            {
                UnitDictionary[nameOfUnit].CountOfUnit += count;
                MyInfo.Coins -= UnitDictionary[nameOfUnit].Price * count;
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
