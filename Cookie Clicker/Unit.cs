namespace Cookie_Clicker
{
    public class Unit
    {
        public int countOfUnit;
        public TypeOfUnit type;
        public int price;
        public int damageDealt;

        public Unit(int countOfUnit, TypeOfUnit type, int price, int damageDealt)
        {
            this.countOfUnit = countOfUnit;
            this.type = type;
            this.price = price;
            this.damageDealt = damageDealt;
        }
    }

    public enum TypeOfUnit
    {
        RangePower,
        MeleePower,
        MagicalPower
    }
}