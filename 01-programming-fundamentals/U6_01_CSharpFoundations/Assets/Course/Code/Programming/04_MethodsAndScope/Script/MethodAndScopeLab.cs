using UnityEngine;

public sealed class MethodsAndScopeLab : MonoBehaviour
{
    private void Start()
    {
        int currentHealth = 100;

        PrintHealth(currentHealth);

        int damage = CalculateDamage(20, 5);

        currentHealth = ApplyDamage(currentHealth, damage);

        PrintHealth(currentHealth);

        bool canAttack = CanAttack(
            isAlive: currentHealth > 0,
            hasControl: true,
            isStunned: false);

        PrintAttackResult(canAttack);
    }

    private void PrintHealth(int health)
    {
        Debug.Log($"Health: {health}");
    }

    private int CalculateDamage(int baseDamage, int bonusDamage)
    {
        return baseDamage + bonusDamage;
    }

    private int ApplyDamage(int health, int damage)
    {
        health -= damage;

        if (health < 0)
        {
            health = 0;
        }

        return health;
    }

    private bool CanAttack(
        bool isAlive,
        bool hasControl,
        bool isStunned)
    {
        return isAlive && hasControl && !isStunned;
    }

    private void PrintAttackResult(bool canAttack)
    {
        if (canAttack)
        {
            Debug.Log("Attack allowed.");
        }
        else
        {
            Debug.Log("Attack blocked.");
        }
    }
}