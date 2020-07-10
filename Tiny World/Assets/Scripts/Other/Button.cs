using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField] Text shotgunText, smgText;
    [SerializeField] Sprite pistolSprite, shotgunSprite, smgSprite;
    [SerializeField] GameObject turretPrefab;

    bool ownShotgun, ownSmg;
    bool soundOff = true;


    public void ChangeToPistol()
    {
        GameObject myPlayer = GameObject.FindGameObjectWithTag("Player");
        myPlayer.GetComponent<PlayerShoot>().pistol = true;
        myPlayer.GetComponent<PlayerShoot>().shotgun = false;
        myPlayer.GetComponent<PlayerShoot>().smg = false;
        GameObject myWeapon = GameObject.FindGameObjectWithTag("Weapon");
        myWeapon.GetComponent<SpriteRenderer>().sprite = pistolSprite;
    }

    public void ChangeToShotgun()
    {
        GameObject myManager = GameObject.FindGameObjectWithTag("GameManager");
        int myCoins = myManager.GetComponent<CoinCount>().countCoins;
        if (ownShotgun == false && myCoins >= 20)
        {
            GameObject myPlayer = GameObject.FindGameObjectWithTag("Player");
            myPlayer.GetComponent<PlayerShoot>().pistol = false;
            myPlayer.GetComponent<PlayerShoot>().shotgun = true;
            myPlayer.GetComponent<PlayerShoot>().smg = false;
            myManager.GetComponent<CoinCount>().countCoins -= 20;
            ownShotgun = true; 
            GameObject myWeapon = GameObject.FindGameObjectWithTag("Weapon");
            myWeapon.GetComponent<SpriteRenderer>().sprite = shotgunSprite;
            shotgunText.text = "Shotgun";

        }
        if (ownShotgun == true)
        {
            GameObject myPlayer = GameObject.FindGameObjectWithTag("Player");
            myPlayer.GetComponent<PlayerShoot>().pistol = false;
            myPlayer.GetComponent<PlayerShoot>().shotgun = true;
            myPlayer.GetComponent<PlayerShoot>().smg = false;
            GameObject myWeapon = GameObject.FindGameObjectWithTag("Weapon");
            myWeapon.GetComponent<SpriteRenderer>().sprite = shotgunSprite;
        }
        
    }

    public void ChangeToSmg()
    {
        GameObject myManager = GameObject.FindGameObjectWithTag("GameManager");
        int myCoins = myManager.GetComponent<CoinCount>().countCoins;

        if (ownSmg == false && myCoins >= 50)
        {
            GameObject myPlayer = GameObject.FindGameObjectWithTag("Player");
            myPlayer.GetComponent<PlayerShoot>().pistol = false;
            myPlayer.GetComponent<PlayerShoot>().shotgun = false;
            myPlayer.GetComponent<PlayerShoot>().smg = true;
            myManager.GetComponent<CoinCount>().countCoins -= 50;
            ownSmg = true;
            GameObject myWeapon = GameObject.FindGameObjectWithTag("Weapon");
            myWeapon.GetComponent<SpriteRenderer>().sprite = smgSprite;
            smgText.text = "SMG";
        }

        if (ownSmg == true)
        {
            GameObject myPlayer = GameObject.FindGameObjectWithTag("Player");
            myPlayer.GetComponent<PlayerShoot>().pistol = false;
            myPlayer.GetComponent<PlayerShoot>().shotgun = false;
            myPlayer.GetComponent<PlayerShoot>().smg = true;
            GameObject myWeapon = GameObject.FindGameObjectWithTag("Weapon");
            myWeapon.GetComponent<SpriteRenderer>().sprite = smgSprite;
        }
    }

    public void PlaceTurret()
    {

    }


}
