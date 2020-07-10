using UnityEngine;

public class RandomSound : MonoBehaviour
{
    [SerializeField] AudioClip[] myPops;
    [SerializeField] AudioSource mySors;


    private void Start()
    {
        PlayRandomPop();
        Destroy(this.gameObject, 1.5f);
    }

    void PlayRandomPop()
    {
        mySors.clip = myPops[Random.Range(0, myPops.Length)];
        mySors.Play();
    }

}
