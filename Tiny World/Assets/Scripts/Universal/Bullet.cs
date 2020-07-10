using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject blueExplode, redExplode, shotSound;
    [SerializeField] bool enemyBullet;


    private void Start()
    {
            GameObject sound = Instantiate(shotSound, transform.position, Quaternion.identity);
            Destroy(sound, 1.2f);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (enemyBullet == false)
        {
            if (collision.tag != "Player")
            {
                if (collision.tag == "Enemy")
                {
                    collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(1);
                }
                if (collision.tag != "Coin")
                {
                    if (collision.tag != "Bullet")
                    {
                        GameObject explosion = Instantiate(blueExplode, transform.position, Quaternion.identity);
                        Destroy(explosion, 2);
                        Destroy(this.gameObject);
                    }
                }
            }
        }


        if (enemyBullet == true)
        {
            if (collision.tag != "Enemy")
            {

                if (collision.tag == "Player")
                {
                    GameObject.FindGameObjectWithTag("GameManager").GetComponent<ShakeScreen>().DamageShake();
                    collision.gameObject.GetComponent<Health>().TakeDamage();
                }
                
                GameObject explosion = Instantiate(redExplode, transform.position, Quaternion.identity);
                Destroy(this.gameObject);

            }
        }

    }


    




}
