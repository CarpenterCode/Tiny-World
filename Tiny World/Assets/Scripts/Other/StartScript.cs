using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{

    private void Start()
    {
        Time.timeScale = 0;
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.V))
        {
            this.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
