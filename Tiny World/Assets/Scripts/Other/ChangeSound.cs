using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class ChangeSound : MonoBehaviour
{
    bool  soundOff = true;

    public void TurnOffSound()
    {
        soundOff = !soundOff;

        if (soundOff == false)
        {
            AudioListener.volume = 0;
        }

        if (soundOff == true)
        {
            AudioListener.volume = 1;
        }

    }
}
