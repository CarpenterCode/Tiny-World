using System.Net.Http.Headers;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab, enemyPrefab2;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float setTimer;
    float _timer;

    int actualChance;
    int myLevel;

    private void Update()
    {
        CheckMyLevel();

        myLevel = GameObject.FindGameObjectWithTag("GameManager").GetComponent<LevelCount>().currentLevel;
        _timer -= Time.deltaTime;
        
        if (_timer <= 0)
        {
            int randomChance = Random.Range(0, 100);
            MaybeSpawn(randomChance);
        }

        switch (myLevel)
        {
            case 1:
                setTimer = 3f;
                break;
            case 2:
                setTimer = 2.75f;
                break;
            case 3:
                setTimer = 2.5f;
                break;
            case 4:
                setTimer = 2f;
                break;
            case 5:
                setTimer = 1.75f;
                break;
            case 6:
                setTimer = 1.75f;
                break;
            default:
                setTimer = 1.5f;
                break;
        }
    }

    void MaybeSpawn(int myChance)
    {
        if (myChance > actualChance)
        {
            if (myLevel >= 5 && myChance > 90)
            {
                Instantiate(enemyPrefab2, spawnPoint.transform.position, Quaternion.identity);
            }
            Instantiate(enemyPrefab, spawnPoint.transform.position, Quaternion.identity);
        }
        _timer = setTimer;
    }

    void CheckMyLevel()
    {
        int myLevel = GameObject.FindGameObjectWithTag("GameManager").GetComponent<LevelCount>().currentLevel;

        switch (myLevel)
        {
            case 1:
                actualChance = 70;
                break;
            case 2:
                actualChance = 70;
                break;
            case 3:
                actualChance = 70;
                break;
            case 4:
                actualChance = 70;
                break;
            case 5:
                actualChance = 70;
                break;
            case 6:
                actualChance = 70;
                break;
            default:
                actualChance = 65;
                break;
        }
    }

}
