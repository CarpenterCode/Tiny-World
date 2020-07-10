using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCoin : MonoBehaviour
{
    public int actualChance;
    [SerializeField] GameObject coinPrefab;

    public void ChanceToDrop()
    {
        int randomChance = Random.Range(0, 100);

        switch (GameObject.FindGameObjectWithTag("GameManager").GetComponent<LevelCount>().currentLevel)
        {
            case 1:
                actualChance = 15;
                break;
            case 2:
                actualChance = 15;
                break;
            case 3:
                actualChance = 25;
                break;
            default:
                actualChance = 45;
                break;
        }

        Debug.Log(actualChance);

        if (randomChance > actualChance)
        {
            Instantiate(coinPrefab, transform.position, Quaternion.identity);
        }
    }
}
