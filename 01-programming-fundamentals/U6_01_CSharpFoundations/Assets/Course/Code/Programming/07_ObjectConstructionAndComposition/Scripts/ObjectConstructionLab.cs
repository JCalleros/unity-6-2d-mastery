using UnityEngine;

namespace Course.Programming.ObjectConstructionAndComposition
{
    public class ObjectConstructionLab :
        MonoBehaviour
    {
        private void Start()
        {
            Weapon trainingSword = new Weapon();
            
            Weapon enemyAxe = 
                new Weapon(
                    "Rusty Axe",
                    14);

            PlayerStats playerStats = 
                new PlayerStats(100);

            PlayerStats enemyStats = 
                new PlayerStats(50);

            Combatant player =
                new Combatant(
                    "Player",
                    playerStats,
                    trainingSword);

            Combatant enemy =
                new Combatant(
                    "Enemy",
                    enemyStats,
                    enemyAxe);

            Debug.Log(
                $"{player.Name} weapon: " +
                $"{player.Weapon.Name}");

            Debug.Log(
                $"Normal damage: " +
                $"{player.Weapon.CalculateDamage()}");
                
            Debug.Log(
                $"{enemy.Name} health before: " +
                $"{enemy.Stats.CurrentHealth}");

            player.Attack(enemy);

            Debug.Log(
                $"{enemy.Name} health after normal attack: " +
                $"{enemy.Stats.CurrentHealth}");

            player.Attack(
                enemy,
                5);

            Debug.Log(
                $"{enemy.Name} health after bonus attack: " +
                $"{enemy.Stats.CurrentHealth}");

            Debug.Log(
                $"Negative utility tests: " +
                $"{DamageMath.Add(-10, 4)}");
        }
    }
}
