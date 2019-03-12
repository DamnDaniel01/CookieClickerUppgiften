using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeAchievements : MonoBehaviour
{
    ShopControl shop123;

    public GameObject autoClicker100Cookies;

    bool timerStarted;

    public AudioSource audioSrc;
    public static AudioClip popEffect;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        popEffect = Resources.Load<AudioClip>("Pop");

        autoClicker100Cookies.SetActive(false);
        shop123 = GameObject.FindWithTag("Player").GetComponent<ShopControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AutoClickerAchievement()
    {
        if (shop123.autoClicker1Sold == true && timerStarted == false)
        {
            StartCoroutine("AutoClickerCountDown");
            timerStarted = true;
        }
    }

    // Eftersom achievementet ska poppa upp efter jag fått 100 kakor med autoclickern, så väntar jag 100 sekunder eftersom man får 1 kaka / sekund
    IEnumerator AutoClickerCountDown()
    {
        yield return new WaitForSeconds(100f);
        audioSrc.PlayOneShot(popEffect);
        autoClicker100Cookies.SetActive(true);
        yield return new WaitForSeconds(5f);
        autoClicker100Cookies.SetActive(false);
    }
}
