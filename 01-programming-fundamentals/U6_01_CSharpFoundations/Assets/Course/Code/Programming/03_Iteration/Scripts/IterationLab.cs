using UnityEngine;

public sealed class IterationLab : MonoBehaviour
{
    void Start()
    {
        Debug.Log("=== FOR ===");

        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"Iteration: {i}");
        }

        Debug.Log("=== WHILE ===");

        int health = 100;

        while (health > 0)
        {
            health -= 25;

            Debug.Log($"Health: {health}");
        }

        Debug.Log("=== DO WHILE ===");

        int attempts = 0;

        do
        {
            attempts++;

            Debug.Log($"Attempt: {attempts}");
        }
        while (attempts < 3);
    }

}
