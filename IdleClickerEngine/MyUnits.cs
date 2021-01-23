using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace IdleClickerEngine
{
    public class MyUnits
    {
        public Dictionary<string, Unit> UnitDictionary { get; private set; }
        private static MyUnits _instance;

        private MyUnits()
        {
        }

        /// <summary>
        /// Singleton of MyUnits
        /// </summary>
        /// <returns></returns>
        public static MyUnits GetInstance()
        {
            return _instance ?? (_instance = new MyUnits());
        }

        /// <summary>
        /// Prepare your dictionary on start of the program
        /// </summary>
        /// <param name="path"></param>
        public void InitiateDictionary(string path)
        {
            //If file doesn't exists inicialize dictionary with zero units
            if (!File.Exists(path))
            {
                InitiateDictionaryWithoutFile();
            }
            //else initialize from txt dictionary
            else
            {
                InitializeDictionaryFromFile(path);
            }
        }

        /// <summary>
        /// Every second count your passive points
        /// </summary>
        /// <returns></returns>
        public BigInteger GetDpsOfYourUnits()
        {
            return UnitDictionary.Aggregate<KeyValuePair<string, Unit>, BigInteger>(0, (current, unit) => current + unit.Value.CountOfUnit * unit.Value.DamageDealt);
        }

        /// <summary>
        /// Buy selected count of your selected unit
        /// </summary>
        /// <param name="nameOfUnit"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public bool BuyUnit(string nameOfUnit, BigInteger count = default)
        {
            //It is for cause when you want buy units for all your many, then it will calculate
            //how many units you can buy
            if(count == default)
            {
                count = MyInfo.Coins / UnitDictionary[nameOfUnit].Price;
            }

            //If you don't have enough coins it will return falls
            if (MyInfo.Coins < UnitDictionary[nameOfUnit].Price * count)
            {
                return false;
            }

            //Buy units, subtract coins and then it will return true, because transaction succeed 
            UnitDictionary[nameOfUnit].CountOfUnit += count;
            MyInfo.Coins -= UnitDictionary[nameOfUnit].Price * count;
            return true;

        }

        /// <summary>
        /// Initiate dictionary without file
        /// </summary>
        private void InitiateDictionaryWithoutFile()
        {
            UnitDictionary = new Dictionary<string, Unit>
            {
                {"basic unit", new Unit(0, TypeOfUnit.MeleePower, 1, 10)},
                {"intermediate unit", new Unit(0, TypeOfUnit.MagicalPower, 10, 1000)},
                {"hard unit", new Unit(0, TypeOfUnit.MagicalPower, 100, 10000)},
                {"extreme unit", new Unit(0, TypeOfUnit.RangePower, 1000, 1000000)},
            };
        }

        /// <summary>
        /// Initialize from file
        /// </summary>
        /// <param name="path"></param>
        private  void InitializeDictionaryFromFile(string path)
        {
            FileWorker worker = new FileWorker(path);
            UnitDictionary = worker.LoadUnits();
        }
    }
}
