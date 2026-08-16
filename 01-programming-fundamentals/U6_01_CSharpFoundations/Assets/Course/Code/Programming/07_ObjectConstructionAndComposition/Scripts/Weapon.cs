namespace Course.Programming.ObjectConstructionAndComposition
{
    public sealed class Weapon
    {
        public string Name { get; private set; }
        public int BaseDamage { get; private set; }

        public Weapon()
            : this("Training Sword", 10)
        {
        }

        public Weapon(
            string name,
            int baseDamage)
        {
            if (baseDamage < 0)
            {
                baseDamage = 0;
            }

            Name = name;
            BaseDamage = baseDamage;
        }

        public int CalculateDamage()
        {
            return DamageMath.Add(
                BaseDamage,
                0);
        }

        public int CalculateDamage(
            int bonusDamage)
        {
            return DamageMath.Add(
                BaseDamage,
                bonusDamage);
        }
    }
}