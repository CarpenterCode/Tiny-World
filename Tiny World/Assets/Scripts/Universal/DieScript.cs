using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieScript : MonoBehaviour
{
    [SerializeField] GameObject enemyExplosion, popSound;
    [SerializeField] bool isPlayer;
    GameObject myManager;

    private void Start()
    {
        myManager = GameObject.FindGameObjectWithTag("GameManager");
    }
    public void MinusEnemy()
    {
        if (isPlayer == false)
        {
            Instantiate(enemyExplosion, transform.position, Quaternion.identity);
            Instantiate(popSound, transform.position, Quaternion.identity);
            myManager.GetComponent<ShakeScreen>().ShakeMyCamera();
            myManager.GetComponent<EnemyCount>()._killedEnemies++;
            myManager.GetComponent<EnemyCount>().enemyToKill--;
            this.gameObject.GetComponent<DropCoin>().ChanceToDrop();
        }
    }

    public void YouLost()
    {
        if (isPlayer == true)
        {
            myManager.GetComponent<ActivateScreen>().ActivateLoss();
        }
    }

}
