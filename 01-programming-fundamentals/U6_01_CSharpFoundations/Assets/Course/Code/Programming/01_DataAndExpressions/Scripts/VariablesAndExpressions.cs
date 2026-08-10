using UnityEngine;

public sealed class VariablesAndExpressions : MonoBehaviour
{
    private void Start()
    {
        int maximunHealth = 100;
        int damage = 25;
        int currentHelath = maximunHealth - damage;

        float movementSpeed = 7.5f;
        bool isAlive = true;
        string playerName = "Player";

        Debug.Log($"Player: {playerName}");
        Debug.Log($"Health: {currentHelath/maximunHealth}");
        Debug.Log($"Movement Speed: {movementSpeed}");
        Debug.Log($"Alive: {isAlive}");
    }
}


