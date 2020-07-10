using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] bool isWin;

    GameObject[] enemyObjects, bulletObjects;

    int enemyPlus;
    int myLevel;
    private void Update()
    {
        CheckLevel();

        if (Input.GetKeyDown(KeyCode.V) && isWin == false)
        {
            LooseSequence();
        }

        if (Input.GetKeyDown(KeyCode.V) && isWin == true)
        {
            WinSequence();
        }

    }
    private void OnEnable()
    {
        Time.timeScale = 0;
    }

    private void OnDisable()
    {
        Time.timeScale = 1;
    }

    void WinSequence()
    {
            enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");
            for (int i = 0; i < enemyObjects.Length; i++)
            {
                Destroy(enemyObjects[i]);
            }

            bulletObjects = GameObject.FindGameObjectsWithTag("Bullet");
            for (int i = 0; i < bulletObjects.Length; i++)
            {
                Destroy(bulletObjects[i]);
            }

        GameObject.FindGameObjectWithTag("GameManager").GetComponent<LevelCount>().currentLevel++;
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<EnemyCount>().enemyToKill += enemyPlus;
        this.gameObject.SetActive(false);
    }

    void LooseSequence()
    {
        string myName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(myName);
        this.gameObject.SetActive(false);
    }

    void CheckLevel()
    {
        myLevel = GameObject.FindGameObjectWithTag("GameManager").GetComponent<LevelCount>().currentLevel;
        switch (myLevel)
        {
            case 1:
                enemyPlus = 10;
                break;
            case 2:
                enemyPlus = 20;
                break;
            case 3:
                enemyPlus = 30;
                break;
            case 4:
                enemyPlus = 40;
                break;
            case 5:
                enemyPlus = 50;
                break;
            case 6:
                enemyPlus = 75;
                break;
            case 7:
                enemyPlus = 100;
                break;
        }

    }
}
