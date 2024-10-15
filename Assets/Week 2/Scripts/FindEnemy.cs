using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : MonoBehaviour
{
    //----------------------Edit below here --------------------
    public Enemy FindEnemyWithSmallestHealth(List<Enemy> enemies)
    {
        Enemy sHPenemy = enemies[0];
        foreach (Enemy enemy in enemies)
        {
            if (sHPenemy.GetHP() > enemy.GetHP()) sHPenemy = enemy;
        }
        return sHPenemy;
    }

    public Enemy FindEnemyWithLargestHealth(List<Enemy> enemies)
    {
        Enemy sHPenemy = enemies[0];
        foreach (Enemy enemy in enemies)
        {
            if (sHPenemy.GetHP() < enemy.GetHP()) sHPenemy = enemy;
        }
        return sHPenemy;
    }

    //----------------------Edit above here --------------------
}
