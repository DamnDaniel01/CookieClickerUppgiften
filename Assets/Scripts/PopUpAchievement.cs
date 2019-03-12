using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpAchievement : MonoBehaviour
{
    public GameObject[] Clicked;
    public GameObject[] Cookies;

    CookieScript kakScript;

    bool clicked1Started, clicked10Started, clicked100Started, clicked1000Started;

    bool cookie7Started, cookie404Started, cookie1337Started, cookie9001Started;

    // Ljud-relaterat
    public AudioSource audioSrc;
    public static AudioClip popEffect;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        popEffect = Resources.Load<AudioClip>("Pop");

        kakScript = GameObject.FindWithTag("Cookie").GetComponent<CookieScript>();

        for (int i = 0; i < Clicked.Length; i++)
        {
            Clicked[i].SetActive(false);
        }

        for (int i = 0; i < Cookies.Length; i++)
        {
            Cookies[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clicked1Time()
    {
        if (kakScript.clickAmount == 1 && clicked1Started == false)
        {
            StartCoroutine("Clicked1");
            clicked1Started = true;
            audioSrc.PlayOneShot(popEffect);
        }
    }

   public void Clicked10Times()
    {
        if (kakScript.clickAmount == 10 && clicked10Started == false)
        {
            StartCoroutine("Clicked10");
            clicked10Started = true;
            audioSrc.PlayOneShot(popEffect);
        }
    }

    public void Clicked100Times()
    {
        if (kakScript.clickAmount == 100 && clicked100Started == false)
        {
            StartCoroutine("Clicked100");
            clicked100Started = true;
            audioSrc.PlayOneShot(popEffect);
        }
    }

    public void Clicked1000Times()
    {
        if (kakScript.clickAmount == 1000 && clicked1000Started == false)
        {
            StartCoroutine("Clicked1000");
            clicked1000Started = true;
            audioSrc.PlayOneShot(popEffect);
        }
    }

    public void CookieEarned7()
    {
        if (Score.totalCookiesEarned >= 7 && cookie7Started == false)
        {
            StartCoroutine("Cookies7");
            cookie7Started = true;
            audioSrc.PlayOneShot(popEffect);
        }
    }

    public void CookieEarned404()
    {
        if (Score.totalCookiesEarned >= 404 && cookie404Started == false)
        {
            StartCoroutine("Cookies404");
            cookie404Started = true;
            audioSrc.PlayOneShot(popEffect);
        }
    }

    public void CookieEarned1337()
    {
        if (Score.totalCookiesEarned >= 1337 && cookie1337Started == false)
        {
            StartCoroutine("Cookies1337");
            cookie1337Started = true;
            audioSrc.PlayOneShot(popEffect);
        }
    }

    public void CookieEarned9001()
    {
        if (Score.totalCookiesEarned >= 9001 && cookie9001Started == false)
        {
            StartCoroutine("Cookies9001");
            cookie9001Started = true;
            audioSrc.PlayOneShot(popEffect);
        }
    }

    IEnumerator Clicked1()
    {
        Clicked[0].SetActive(true);
        yield return new WaitForSeconds(5f);
        Clicked[0].SetActive(false);

    }

    IEnumerator Clicked10()
    {
        Clicked[1].SetActive(true);
        yield return new WaitForSeconds(5f);
        Clicked[1].SetActive(false);
    }

    IEnumerator Clicked100()
    {
        Clicked[2].SetActive(true);
        yield return new WaitForSeconds(5f);
        Clicked[2].SetActive(false);
    }

    IEnumerator Clicked1000()
    {
        Clicked[3].SetActive(true);
        yield return new WaitForSeconds(5f);
        Clicked[3].SetActive(false);
    }

    IEnumerator Cookies7()
    {
        Cookies[0].SetActive(true);
        yield return new WaitForSeconds(5f);
        Cookies[0].SetActive(false);
    }

    IEnumerator Cookies404()
    {
        Cookies[1].SetActive(true);
        yield return new WaitForSeconds(5f);
        Cookies[1].SetActive(false);
    }

    IEnumerator Cookies1337()
    {
        Cookies[2].SetActive(true);
        yield return new WaitForSeconds(5f);
        Cookies[2].SetActive(false);
    }

    IEnumerator Cookies9001()
    {
        Cookies[3].SetActive(true);
        yield return new WaitForSeconds(5f);
        Cookies[3].SetActive(false);
    }
}
