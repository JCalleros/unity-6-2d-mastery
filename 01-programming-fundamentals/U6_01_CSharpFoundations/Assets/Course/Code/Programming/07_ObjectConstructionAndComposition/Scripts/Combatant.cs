public sealed class Combatant
{
    public string Name { get; private set; }
    public PlayerStats Stats { get; private set; }

    public Weapon Weapon { get; private set; }

    public Combatant(
        string name,
        PlayerStats stats,
        Weapon weapon)
    {
        Name = name;
        Stats = stats;
        Weapon = weapon;
    }

    public void Attack(
        Combatant target)
    {
        int damage = Weapon.CalculateDamage();

        target.Stats.TakeDamage(damage);
    }

    public void Attack(
        Combatant target,
        int bonusDamage)
    {
        int damage = Weapon.CalculateDamage(bonusDamage);

        target.Stats.TakeDamage(damage);
    }
}