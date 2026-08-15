public sealed class PlayerStats
{
    public int CurrentHealth { get; private set; }
    public int MaximumHealth { get; private set; }

    public bool IsDead => CurrentHealth <= 0;

    public PlayerStats(int maximumHealth)
    {
        if (maximumHealth < 1)
        {
            maximumHealth = 1;
        }

        MaximumHealth = maximumHealth;
        CurrentHealth = maximumHealth;
    }

    public void TakeDagame(int amount)
    {
        if (amount <= 0)
        {
            return;
        }

        CurrentHealth -= amount;

        if (CurrentHealth < 0)
        {
            CurrentHealth = 0;
        }
    }

    public void Heal(int amount)
    {
        if (amount <= 0)
        {
            return;
        }

        CurrentHealth += amount;

        if(CurrentHealth > MaximumHealth)
        {
            CurrentHealth = MaximumHealth;
        }
    }
}