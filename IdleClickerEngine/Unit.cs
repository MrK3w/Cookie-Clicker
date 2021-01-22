using System.Numerics;

namespace IdleClickerEngine
{
    public class Unit
    {
        public BigInteger CountOfUnit;
        public TypeOfUnit Type;
        public BigInteger Price;
        public BigInteger DamageDealt;

        public Unit(BigInteger countOfUnit, TypeOfUnit type, BigInteger price, BigInteger damageDealt)
        {
            CountOfUnit = countOfUnit;
            Type = type;
            Price = price;
            DamageDealt = damageDealt;
        }
    }
}