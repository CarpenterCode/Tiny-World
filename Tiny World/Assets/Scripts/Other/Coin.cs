using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] GameObject coinSound;
    [SerializeField] float timeToDestroy = 10;
    private void Start()
    {
        Destroy(this.gameObject, timeToDestroy);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<CoinCount>().countCoins++;
            GameObject sound = Instantiate(coinSound, transform.position, Quaternion.identity);
            Destroy(sound, 1.5f);
            Destroy(this.gameObject);
        }
    }
}
