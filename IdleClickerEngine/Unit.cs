namespace IdleClickerEngine
{
    public class Unit
    {
        public int CountOfUnit;
        public TypeOfUnit Type;
        public int Price;
        public int DamageDealt;

        public Unit(int countOfUnit, TypeOfUnit type, int price, int damageDealt)
        {
            CountOfUnit = countOfUnit;
            Type = type;
            Price = price;
            DamageDealt = damageDealt;
        }
    }
}