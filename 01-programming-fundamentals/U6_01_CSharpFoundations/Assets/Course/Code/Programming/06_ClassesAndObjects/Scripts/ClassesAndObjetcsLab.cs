using UnityEngine;

public sealed class ClassAndObjectsLab : MonoBehaviour
{
    [SerializeField]
    private int playerMaximumHealth = 100;
    [SerializeField]
    private int bossMaximumHealth = 500;

    private void Start()
    {
        RunIndependentInstancesExample();
        RunReferenceExample();
    }

    private void RunIndependentInstancesExample()
    {
        PlayerStats player = new PlayerStats(playerMaximumHealth);
        PlayerStats boss = new PlayerStats(bossMaximumHealth);

        player.TakeDamage(25);
        boss.TakeDamage(100);

        Debug.Log($"Player Health: {player.CurrentHealth}");
        Debug.Log($"Boss Health: {boss.CurrentHealth}");
    }

    private void RunReferenceExample()
    {
        PlayerStats player = new PlayerStats(playerMaximumHealth);
        PlayerStats anotherReference = player;

        anotherReference.TakeDamage(40);

        Debug.Log($"Original reference: {player.CurrentHealth}");
        Debug.Log($"Second reference: {anotherReference.CurrentHealth}");
    }
}