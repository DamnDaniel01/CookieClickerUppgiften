using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CookieScript : MonoBehaviour
{
    public GameObject backgroundCookie;

    public int randomNum;

    int cookieMultiplier;

    public int clickAmount;

    public float rayLength;
    public LayerMask layerMask;

    ShopControl Shop;

    // Skala och positionen på kakan
    Vector3 scale;
    Vector3 position;

    // Ljud-relaterat
    AudioSource audioSrc;
    public static AudioClip clickEffect;

    // Start is called before the first frame update
    void Start()
    {
        cookieMultiplier = 1;

        Shop = GameObject.FindGameObjectWithTag("Player").GetComponent<ShopControl>();

        audioSrc = GetComponent<AudioSource>();
        clickEffect = Resources.Load<AudioClip>("Click Effect");
    }

    // Update is called once per frame
    void Update()
    {
        randomNum = UnityEngine.Random.Range(-14, 14);

        if (Shop.duplicatorSold == true)
        {
            cookieMultiplier = 2;
        }

        if (Shop.tripleSold == true)
        {
            cookieMultiplier = 3;
        }

        if (Shop.duplicatorSold == true && Shop.tripleSold == true)
        {
            cookieMultiplier = 6; 
        }
    }

    // Public för att kunna nå den i Events scriptet
    public void CookiePressed()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, rayLength, layerMask))
            {
                Instantiate(backgroundCookie, new Vector3(randomNum, 9, 14), backgroundCookie.transform.rotation);

                Score.cookieAmount += cookieMultiplier;

                Score.totalCookiesEarned += cookieMultiplier;

                clickAmount += 1;

                StartCoroutine("ScaleUp");

                audioSrc.PlayOneShot(clickEffect);
            }
        }
    }
    // Själva animationen när man klickar på kakan
    IEnumerator ScaleUp()
    {
        position = transform.position;

        scale = transform.localScale;

        position = new Vector3(0.0053631f, -5.2421f, 13.681f);

        scale = new Vector3(0.75f, 0.75f, 0.75f);

        transform.position = position;

        transform.localScale = scale;

        yield return new WaitForSeconds(0.1f);

        position = new Vector3(0, -5, 13.679f);

        scale = new Vector3(0.7f, 0.7f, 0.7f);

        transform.localScale = scale;

        transform.position = position;
    }
}
