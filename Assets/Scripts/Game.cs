using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Text ui;

    public void Increment()
    {
        GameManager.logs += GameManager.multiplier;
        PlayerPrefs.SetInt("logs", GameManager.logs);
    }

    public void Buy(int num)
    {
        if(num == 1 && GameManager.logs >= 25)
        {
            GameManager.multiplier += 1;
            GameManager.logs -= 25;
            PlayerPrefs.SetInt("logs", GameManager.logs);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 2 && GameManager.logs >= 125)
        {
            GameManager.multiplier += 10;
            GameManager.logs -= 125;
            PlayerPrefs.SetInt("logs", GameManager.logs);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 3 && GameManager.logs >= 1500)
        {
            GameManager.multiplier += 100;
            GameManager.logs -= 1500;
            PlayerPrefs.SetInt("logs", GameManager.logs);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }


    }    

    void Update()
    {
        ui.text = "Logs: " + GameManager.logs;
    }
}
