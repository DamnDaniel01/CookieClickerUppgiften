using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : CookieScript
{
    public static int cookieAmount = 0;

    public static int totalCookiesEarned = 0;

    private TMP_Text m_TextComponent;

    ShopControl Shop1;

    // Start is called before the first frame update
    void Start()
    {
        Shop1 = GameObject.FindGameObjectWithTag("Player").GetComponent<ShopControl>();

        m_TextComponent = GetComponent<TMP_Text>();

        InvokeRepeating("AutoClicker1Enabled", 0f, 1.0f);

        InvokeRepeating("AutoClicker2Enabled", 0f, 1.0f);

        InvokeRepeating("AutoClicker3Enabled", 0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        m_TextComponent.text = cookieAmount + " cookies";

        randomNum = UnityEngine.Random.Range(-14, 14);

        if (Input.GetKeyDown(KeyCode.S))
        {
            print(totalCookiesEarned);
        }
    }

    void AutoClicker1Enabled()
    {
        if (Shop1.autoClicker1Sold == true)
        {
            cookieAmount += 1;

            totalCookiesEarned += 1;

            Instantiate(backgroundCookie, new Vector3(randomNum, 9, 14), backgroundCookie.transform.rotation);
        }
    }

    void AutoClicker2Enabled()
    {
        if (Shop1.autoClicker2Sold == true)
        {
            cookieAmount += 5;

            totalCookiesEarned += 5;

            Instantiate(backgroundCookie, new Vector3(randomNum, 9, 14), backgroundCookie.transform.rotation);
        }
    }

    void AutoClicker3Enabled()
    {
        if (Shop1.autoClicker3Sold == true)
        {
            cookieAmount += 20;

            totalCookiesEarned += 20;

            Instantiate(backgroundCookie, new Vector3(randomNum, 9, 14), backgroundCookie.transform.rotation);
        }
    }

    IEnumerator AutoClicker1Started()
    {
        yield return new WaitForSeconds(1f);
        cookieAmount += 1;
        Instantiate(backgroundCookie, new Vector3(randomNum, 9, 14), backgroundCookie.transform.rotation);
    }
}
