using UnityEngine;
using UnityEngine.UI;

public class LevelCount : MonoBehaviour
{
    [SerializeField] Text levelCount;

    public int currentLevel;

    private void Update()
    {
        levelCount.text = currentLevel.ToString();
    }


    
}
