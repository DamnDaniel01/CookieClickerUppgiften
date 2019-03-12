using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{
    public event Action CookieClicked;

    public event Action TimesClicked;

    public event Action CookiesEarned;

    public event Action AutoClicker1Achievement;

    // Start is called before the first frame update
    void Start()
    {
        // När man trycker på kakan
        CookieClicked += GameObject.FindWithTag("Cookie").GetComponent<CookieScript>().CookiePressed;

        // Lägger till achievement för antalet gånger man klickat på kakan
        TimesClicked += GameObject.FindWithTag("Achievement").GetComponent<PopUpAchievement>().Clicked1Time;
        TimesClicked += GameObject.FindWithTag("Achievement").GetComponent<PopUpAchievement>().Clicked10Times;
        TimesClicked += GameObject.FindWithTag("Achievement").GetComponent<PopUpAchievement>().Clicked100Times;
        TimesClicked += GameObject.FindWithTag("Achievement").GetComponent<PopUpAchievement>().Clicked1000Times;

        // Lägger till achievement för hur många kakor man producerat
        CookiesEarned += GameObject.FindWithTag("Achievement").GetComponent<PopUpAchievement>().CookieEarned7;
        CookiesEarned += GameObject.FindWithTag("Achievement").GetComponent<PopUpAchievement>().CookieEarned404;
        CookiesEarned += GameObject.FindWithTag("Achievement").GetComponent<PopUpAchievement>().CookieEarned1337;
        CookiesEarned += GameObject.FindWithTag("Achievement").GetComponent<PopUpAchievement>().CookieEarned9001;

        // Achievementet när man har producerat 100 kakor med den första autoclickern
        AutoClicker1Achievement += GameObject.FindWithTag("Achievement").GetComponent<UpgradeAchievements>().AutoClickerAchievement;
    }

    // Update is called once per frame
    void Update()
    {
        CookieClicked?.Invoke();

        TimesClicked?.Invoke();

        CookiesEarned?.Invoke();

        AutoClicker1Achievement?.Invoke();
    }
}
