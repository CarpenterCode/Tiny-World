using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateScreen : MonoBehaviour
{
    [SerializeField] GameObject lossScreen, winScreen;

    public void ActivateLoss()
    {
        lossScreen.SetActive(true);
    }

    public void ActivateWin()
    {
        winScreen.SetActive(true);
    }
}
