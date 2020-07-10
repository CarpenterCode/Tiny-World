using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour
{
    public int enemyToKill = 10;
    public int _killedEnemies = 0;

    [SerializeField] Text enemyCount;
    [SerializeField] Text totalEnemiesLoss, totalEnemiesWin;

    private void Update()
    {
        if (enemyToKill <= 0)
        {
            this.gameObject.GetComponent<ActivateScreen>().ActivateWin();
        }

        
        enemyCount.text = enemyToKill.ToString();
        totalEnemiesLoss.text = _killedEnemies.ToString();
        totalEnemiesWin.text = _killedEnemies.ToString();

        
    }
}
