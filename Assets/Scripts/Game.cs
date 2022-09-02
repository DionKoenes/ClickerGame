using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Text ui;

    public int logs;
    public int multiplier;

    public void Increment()
    {
        logs += multiplier;
        PlayerPrefs.SetInt("logs", logs);
    }

    public void Buy(int num)
    {
        if(num == 1 && logs >= 25)
        {
            multiplier += 1;
            logs -= 25;
            PlayerPrefs.SetInt("logs", logs);
            PlayerPrefs.SetInt("multiplier", multiplier);
        }

        if (num == 2 && logs >= 125)
        {
            multiplier += 10;
            logs -= 125;
            PlayerPrefs.SetInt("logs", logs);
            PlayerPrefs.SetInt("multiplier", multiplier);
        }

        if (num == 3 && logs >= 1500)
        {
            multiplier += 100;
            logs -= 1500;
            PlayerPrefs.SetInt("logs", logs);
            PlayerPrefs.SetInt("multiplier", multiplier);
        }


    }    

    void Update()
    {
        ui.text = "Logs: " + logs;
    }
}
