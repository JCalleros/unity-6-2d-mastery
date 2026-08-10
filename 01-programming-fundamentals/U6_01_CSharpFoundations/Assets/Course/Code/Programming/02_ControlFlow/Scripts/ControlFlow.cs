using UnityEngine;

public sealed class ControlFlow : MonoBehaviour
{
    private void Start()
    {
        int maximumHealth = 100;
        int currentHealth = 35;

        bool isAlive = currentHealth > 0;
        bool isFullHealth = currentHealth == maximumHealth;
        bool isCriticalHealth = currentHealth > 0
            && currentHealth <= maximumHealth * 0.25f;

        Debug.Log($"Alive: {isAlive}");
        Debug.Log($"Full Health: {isFullHealth}");
        Debug.Log($"Critical Health: {isCriticalHealth}");

        if (!isAlive)
        {
            Debug.Log("Player state: Dead");
        }
        else if (isCriticalHealth)
        {
            Debug.Log("Player state: Critical");
        }
        else if (!isFullHealth)
        {
            Debug.Log("Player state: Damaged");
        }
        else
        {
            Debug.Log("Player state: Full Health");
        }
    }
}
