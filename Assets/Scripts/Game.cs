using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Text ui;

    public void Increment()
    {
        GameManager.logs += GameManager.multiplier;
    }

    public void Buy(int num)
    {
        if(num == 1 && GameManager.logs >= 25)
        {
            GameManager.multiplier += 1;
            GameManager.logs -= 25;
        }

        if (num == 2 && GameManager.logs >= 125)
        {
            GameManager.multiplier += 10;
            GameManager.logs -= 125;
        }

        if (num == 3 && GameManager.logs >= 1500)
        {
            GameManager.multiplier += 100;
            GameManager.logs -= 1500;
        }


    }    

    void Update()
    {
        ui.text = "Logs: " + GameManager.logs;
    }
}
