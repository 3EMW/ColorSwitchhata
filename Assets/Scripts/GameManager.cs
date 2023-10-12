using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UIManager uimanager;

    void Start()
    {
        CoinCalculator(0);
        Debug.Log(PlayerPrefs.GetInt("moneys"));
    }

    public void CoinCalculator(int money)
    {
        if (PlayerPrefs.HasKey("moneys"))
        {
            int oldScore = PlayerPrefs.GetInt("moneys");
            PlayerPrefs.SetInt("moneys", oldScore + money);
        }
        else
        {
            PlayerPrefs.SetInt("moneys", 0);
        }
    }
}
