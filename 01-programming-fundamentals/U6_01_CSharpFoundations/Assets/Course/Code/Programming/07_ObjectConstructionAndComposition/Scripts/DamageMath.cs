public static class DamageMath
{
    public static int Add(
        int baseDamage,
        int bonusDamage)
    {
        if (baseDamage < 0)
        {
            baseDamage = 0;
        }

        if (bonusDamage < 0)
        {
            bonusDamage = 0;
        }

        return baseDamage + bonusDamage;
    }
}