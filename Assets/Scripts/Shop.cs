using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.ParticleSystem;

public class Shop : MonoBehaviour
{
    public UIManager uimanager;
    //public GameObject ball0;
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;
    public GameObject ball5;
    public GameObject ball6;
    public GameObject ball7;
    //public GameObject ball8;

    public Sprite yellowImage;
    public Sprite greenImage;
    //public GameObject item0;
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject item5;
    public GameObject item6;
    public GameObject item7;
    //public GameObject item8;
    public GameObject lock1;
    public GameObject lock2;
    public GameObject lock3;
    public GameObject lock4;
    public GameObject lock5;
    public GameObject lock6;
    //public GameObject lock7;

    public void Awake()
    {
        if (PlayerPrefs.HasKey("itemselect") == false)
            PlayerPrefs.SetInt("itemselect", 0);
        //----------SELECT----------
        if (PlayerPrefs.GetInt("itemselect", 0) == 0)
            Item1Open();
        else if (PlayerPrefs.GetInt("itemselect") == 1)
            Item2Open();
        else if (PlayerPrefs.GetInt("itemselect") == 2)
            Item3Open();
        else if (PlayerPrefs.GetInt("itemselect") == 3)
            Item4Open();
        else if (PlayerPrefs.GetInt("itemselect") == 5)
            Item6Open();
        else if (PlayerPrefs.GetInt("itemselect") == 6)
            Item7Open();

        //----------LOCKS----------
        if (PlayerPrefs.HasKey("lock1control") == false)
            PlayerPrefs.SetInt("lock1control", 0);
        if (PlayerPrefs.HasKey("lock2control") == false)
            PlayerPrefs.SetInt("lock2control", 0);
        if (PlayerPrefs.HasKey("lock3control") == false)
            PlayerPrefs.SetInt("lock3control", 0);
        if (PlayerPrefs.HasKey("lock4control") == false)
            PlayerPrefs.SetInt("lock4control", 0);
        if (PlayerPrefs.HasKey("lock5control") == false)
            PlayerPrefs.SetInt("lock5control", 0);
        if (PlayerPrefs.HasKey("lock6control") == false)
            PlayerPrefs.SetInt("lock6control", 0);
        if (PlayerPrefs.HasKey("lock7control") == false)
            PlayerPrefs.SetInt("lock7control", 0);

        if (PlayerPrefs.GetInt("lock1control") == 1)
            lock1.SetActive(false);
        if (PlayerPrefs.GetInt("lock2control") == 1)
            lock2.SetActive(false);
        if (PlayerPrefs.GetInt("lock3control") == 1)
            lock3.SetActive(false);
        if (PlayerPrefs.GetInt("lock4control") == 1)
            lock4.SetActive(false);
        if (PlayerPrefs.GetInt("lock5control") == 1)
            lock5.SetActive(false);
        if (PlayerPrefs.GetInt("lock6control") == 1)
            lock6.SetActive(false);
        //if (PlayerPrefs.GetInt("lock7control") == 1) lock7.SetActive(false);
    }
    public void Item1Open()
    {
        //ball0.SetActive(false);
        ball1.SetActive(true);
        ball2.SetActive(false);
        ball3.SetActive(false);
        ball4.SetActive(false);
        ball5.SetActive(false);
        ball6.SetActive(false);
        ball7.SetActive(false);
        //ball8.SetActive(false);

        item1.GetComponent<Image>().sprite = greenImage;
        item2.GetComponent<Image>().sprite = yellowImage;
        item3.GetComponent<Image>().sprite = yellowImage;
        item4.GetComponent<Image>().sprite = yellowImage;
        item5.GetComponent<Image>().sprite = yellowImage;
        item6.GetComponent<Image>().sprite= yellowImage;
        item7.GetComponent<Image>().sprite = yellowImage;
        //item8.GetComponent<Image>().sprite = yellowImage;
        PlayerPrefs.SetInt("itemselect", 0);
    }

    public void Item2Open()
    {
        //ball0.SetActive(false);
        ball1.SetActive(false);
        ball2.SetActive(true);
        ball3.SetActive(false);
        ball4.SetActive(false);
        ball5.SetActive(false);
        ball6.SetActive(false);
        ball7.SetActive(false);
        //ball8.SetActive(false);

        item1.GetComponent<Image>().sprite = yellowImage;
        item2.GetComponent<Image>().sprite = greenImage;
        item3.GetComponent<Image>().sprite = yellowImage;
        item4.GetComponent<Image>().sprite = yellowImage;
        item5.GetComponent<Image>().sprite = yellowImage;
        item6.GetComponent<Image>().sprite = yellowImage;
        item7.GetComponent<Image>().sprite = yellowImage;
        //item8.GetComponent<Image>().sprite = yellowImage;
        PlayerPrefs.SetInt("itemselect", 1);
    }
    public void Item3Open()
    {
        //ball0.SetActive(false);
        ball1.SetActive(false);
        ball2.SetActive(false);
        ball3.SetActive(true);
        ball4.SetActive(false);
        ball5.SetActive(false);
        ball6.SetActive(false);
        ball7.SetActive(false);
        //ball8.SetActive(false);

        item1.GetComponent<Image>().sprite = yellowImage;
        item2.GetComponent<Image>().sprite = yellowImage;
        item3.GetComponent<Image>().sprite = greenImage;
        item4.GetComponent<Image>().sprite = yellowImage;
        item5.GetComponent<Image>().sprite = yellowImage;
        item6.GetComponent<Image>().sprite = yellowImage;
        item7.GetComponent<Image>().sprite = yellowImage;
        //item8.GetComponent<Image>().sprite = yellowImage;
        PlayerPrefs.SetInt("itemselect", 2);
    }
    public void Item4Open()
    {
        //ball0.SetActive(false);
        ball1.SetActive(false);
        ball2.SetActive(false);
        ball3.SetActive(false);
        ball4.SetActive(true);
        ball5.SetActive(false);
        ball6.SetActive(false);
        ball7.SetActive(false);
        //ball8.SetActive(false);

        item1.GetComponent<Image>().sprite = yellowImage;
        item2.GetComponent<Image>().sprite = yellowImage;
        item3.GetComponent<Image>().sprite = yellowImage;
        item4.GetComponent<Image>().sprite = greenImage;
        item5.GetComponent<Image>().sprite = yellowImage;
        item6.GetComponent<Image>().sprite = yellowImage;
        item7.GetComponent<Image>().sprite = yellowImage;
        //item8.GetComponent<Image>().sprite = yellowImage;
        PlayerPrefs.SetInt("itemselect", 3);
    }
    public void Item5Open()
    {
        //ball0.SetActive(false);
        ball1.SetActive(false);
        ball2.SetActive(false);
        ball3.SetActive(false);
        ball4.SetActive(false);
        ball5.SetActive(true);
        ball6.SetActive(false);
        ball7.SetActive(false);
        //ball8.SetActive(false);

        item1.GetComponent<Image>().sprite = yellowImage;
        item2.GetComponent<Image>().sprite = yellowImage;
        item3.GetComponent<Image>().sprite = yellowImage;
        item4.GetComponent<Image>().sprite = yellowImage;
        item5.GetComponent<Image>().sprite = greenImage;
        item6.GetComponent<Image>().sprite = yellowImage;
        item7.GetComponent<Image>().sprite = yellowImage;
        //item8.GetComponent<Image>().sprite = yellowImage;
        PlayerPrefs.SetInt("itemselect", 4);
    }
    public void Item6Open()
    {
        //ball0.SetActive(false);
        ball1.SetActive(false);
        ball2.SetActive(false);
        ball3.SetActive(false);
        ball4.SetActive(false);
        ball5.SetActive(false);
        ball6.SetActive(true);
        ball7.SetActive(false);
        //ball8.SetActive(false);

        item1.GetComponent<Image>().sprite = yellowImage;
        item2.GetComponent<Image>().sprite = yellowImage;
        item3.GetComponent<Image>().sprite = yellowImage;
        item4.GetComponent<Image>().sprite = yellowImage;
        item5.GetComponent<Image>().sprite = yellowImage;
        item6.GetComponent<Image>().sprite = greenImage;
        item7.GetComponent<Image>().sprite = yellowImage;
        //item8.GetComponent<Image>().sprite= yellowImage;
        PlayerPrefs.SetInt("itemselect", 5);
    }
    public void Item7Open()
    {
        //ball0.SetActive(false);
        ball1.SetActive(false);
        ball2.SetActive(false);
        ball3.SetActive(false);
        ball4.SetActive(false);
        ball5.SetActive(false);
        ball6.SetActive(false);
        ball7.SetActive(true);
        //ball8.SetActive(false);

        item1.GetComponent<Image>().sprite = yellowImage;
        item2.GetComponent<Image>().sprite = yellowImage;
        item3.GetComponent<Image>().sprite = yellowImage;
        item4.GetComponent<Image>().sprite = yellowImage;
        item5.GetComponent<Image>().sprite = yellowImage;
        item6.GetComponent<Image>().sprite = yellowImage;
        item7.GetComponent<Image>().sprite = greenImage;
        //item8.GetComponent<Image>(). sprite = yellowImage;
        PlayerPrefs.SetInt("itemselect", 6);
    }
    public void Item8Open()
    {
        //ball0.SetActive(false);
        ball1.SetActive(false);
        ball2.SetActive(false);
        ball3.SetActive(false);
        ball4.SetActive(false);
        ball5.SetActive(false);
        ball6.SetActive(false);
        ball7.SetActive(false);
        //ball8.SetActive(true);

        item1.GetComponent<Image>().sprite = yellowImage;
        item2.GetComponent<Image>().sprite = yellowImage;
        item3.GetComponent<Image>().sprite = yellowImage;
        item4.GetComponent<Image>().sprite = yellowImage;
        item5.GetComponent<Image>().sprite = yellowImage;
        item6.GetComponent<Image>().sprite = yellowImage;
        item7.GetComponent<Image>().sprite = yellowImage;
        //item8.GetComponent<Image>().sprite = greenImage;
        PlayerPrefs.SetInt("itemselect", 7);
    }


    public void Lock1Open()
    {
        int money = PlayerPrefs.GetInt("moneys");
        int lock1control = PlayerPrefs.GetInt("lock1control");
        if (money >= 300 && lock1control == 300)
        {
            lock1.SetActive(false);
            PlayerPrefs.SetInt("moneys", money - 0);
            PlayerPrefs.SetInt("lock1control", 1);
            Item2Open();
            uimanager.CoinTextUpdate();
        }
    }
    public void Lock2Open()
    {
        int money = PlayerPrefs.GetInt("moneys");
        int lock2control = PlayerPrefs.GetInt("lock2control");
        if (money >= 500 && lock2control == 0)
        {
            lock2.SetActive(false);
            PlayerPrefs.SetInt("moneys", money - 500);
            PlayerPrefs.SetInt("lock2control", 1);
            Item3Open();
            uimanager.CoinTextUpdate();
        }
    }
    public void Lock3Open()
    {
        int money = PlayerPrefs.GetInt("moneys");
        int lock3control = PlayerPrefs.GetInt("lock3control");
        if (money >= 1000 && lock3control == 0)
        {
            lock3.SetActive(false);
            PlayerPrefs.SetInt("moneys", money - 1000);
            PlayerPrefs.SetInt("lock3control", 1);
            Item4Open();
            uimanager.CoinTextUpdate();
        }
    }
    public void Lock4Open()
    {
        int money = PlayerPrefs.GetInt("moneys");
        int lock4control = PlayerPrefs.GetInt("lock4control");
        if (money >= 2000 && lock4control == 0)
        {
            lock4.SetActive(false);
            PlayerPrefs.SetInt("moneys", money - 2000);
            PlayerPrefs.SetInt("lock4control", 1);
            Item5Open();
            uimanager.CoinTextUpdate();
        }
    }
    public void Lock5Open()
    {
        int money = PlayerPrefs.GetInt("moneys");
        int lock5control = PlayerPrefs.GetInt("lock5control");
        if (money >= 2500 && lock5control == 0)
        {
            lock5.SetActive(false);
            PlayerPrefs.SetInt("moneys", money - 2500);
            PlayerPrefs.SetInt("lock5control", 1);
            Item6Open();
            uimanager.CoinTextUpdate();
        }
    }
    public void Lock6Open()
    {
        int money = PlayerPrefs.GetInt("moneys");
        int lock6control = PlayerPrefs.GetInt("lock6control");
        if (money >= 3000 && lock6control == 0)
        {
            lock6.SetActive(false);
            PlayerPrefs.SetInt("moneys", money - 3000);
            PlayerPrefs.SetInt("lock6control", 1);
            Item7Open();
            uimanager.CoinTextUpdate();
        }
    }

    //public void Lock7Open(){int money = PlayerPrefs.GetInt("moneys");int lock7control = PlayerPrefs.GetInt("lock7control");if (money >= 4000 && lock7control == 0){lock7.SetActive(false);PlayerPrefs.SetInt("moneys", money - 4000);PlayerPrefs.SetInt("lock7control", 1);Item8Open();uimanager.CoinTextUpdate();}}

}
