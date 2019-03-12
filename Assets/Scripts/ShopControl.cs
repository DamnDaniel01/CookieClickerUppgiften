using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopControl : MonoBehaviour
{
    int duplicatorBuyable = 200;

    int tripleBuyable = 400;

    int autoClicker1Buyable = 70;

    int autoClicker2Buyable = 800;

    int autoClicker3Buyable = 2000;

    public Button duplicatorButton;

    public Button tripleButton;

    public Button autoClicker1Button;

    public Button autoClicker2Button;

    public Button autoClicker3Button;

    public TMP_Text duplicatorPrice;

    public TMP_Text triplePrice;

    public TMP_Text autoClicker1Price;

    public TMP_Text autoClicker2Price;

    public TMP_Text autoClicker3Price;

    public bool duplicatorSold = false;

    public bool tripleSold = false;

    public bool autoClicker1Sold = false;

    public bool autoClicker2Sold = false;

    public bool autoClicker3Sold = false;

    public GameObject duplicatorActive;

    public GameObject tripleActive;

    public GameObject autoClicker1Active;

    public GameObject autoclicker2Active;

    public GameObject autoClicker3Active;

    public GameObject sixtupleActive;

    // Start is called before the first frame update
    void Start()
    {
        duplicatorActive.SetActive(false);

        tripleActive.SetActive(false);

        autoClicker1Active.SetActive(false);

        autoclicker2Active.SetActive(false);

        autoClicker3Active.SetActive(false);

        sixtupleActive.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.cookieAmount >= duplicatorBuyable && duplicatorSold == false)
        {
            duplicatorButton.interactable = true;
        }
        else
        {
            duplicatorButton.interactable = false;
        }

        if (Score.cookieAmount >= autoClicker1Buyable && autoClicker1Sold == false)
        {
            autoClicker1Button.interactable = true;
        }
        else
        {
            autoClicker1Button.interactable = false;
        }

        if (Score.cookieAmount >= tripleBuyable && tripleSold == false)
        {
            tripleButton.interactable = true;
        }
        else
        {
            tripleButton.interactable = false;

        }

        if (Score.cookieAmount >= autoClicker2Buyable && autoClicker2Sold == false)
        {
            autoClicker2Button.interactable = true;
        }
        else
        {
            autoClicker2Button.interactable = false;
        }

        if (Score.cookieAmount >= autoClicker3Buyable && autoClicker3Sold == false)
        {
            autoClicker3Button.interactable = true;
        }
        else
        {
            autoClicker3Button.interactable = false;
        }

        if (duplicatorSold == true && tripleSold == true)
        {
            duplicatorActive.SetActive(false);

            tripleActive.SetActive(false);

            sixtupleActive.SetActive(true);
        }
    }

    public void BuyDuplicator()
    {
        Score.cookieAmount -= 200;
        duplicatorButton.interactable = false;
        duplicatorPrice.text = " SOLD!";
        duplicatorSold = true;
        duplicatorActive.SetActive(true);
    }

    public void BuyTripple()
    {
        Score.cookieAmount -= 400;
        tripleButton.interactable = false;
        triplePrice.text = " SOLD!";
        tripleSold = true;
        tripleActive.SetActive(true);
    }

    public void BuyAutoClicker1()
    {
        Score.cookieAmount -= 70;
        autoClicker1Button.interactable = false;
        autoClicker1Price.text = " SOLD!";
        autoClicker1Sold = true;
        autoClicker1Active.SetActive(true);
    }

    public void BuyAutoClicker2()
    {
        Score.cookieAmount -= 800;
        autoClicker2Button.interactable = false;
        autoClicker2Price.text = " SOLD!";
        autoClicker2Sold = true;
        autoclicker2Active.SetActive(true);
    }

    public void BuyAutoClicker3()
    {
        Score.cookieAmount -= 2000;
        autoClicker3Button.interactable = false;
        autoClicker3Price.text = " SOLD!";
        autoClicker3Sold = true;
        autoClicker3Active.SetActive(true);
    }
}
