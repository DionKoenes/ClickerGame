using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Game game;

    void Start()
    {
        game = GameObject.Find("Game").GetComponent<Game>();
        game.multiplier = PlayerPrefs.GetInt("multiplier", 1);
        game.logs = PlayerPrefs.GetInt("logs", 0);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
    }

}
