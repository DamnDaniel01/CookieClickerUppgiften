using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag("Player").GetComponent<EventShow>().Godmorgon += Colorize;

        GameObject.FindWithTag("Player").GetComponent<EventShow>().Godmorgon += AchievementClick3;
    }

    public void Colorize()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    private int clickAmount = 0;

    public void AchievementClick3()
    {
        clickAmount++;

        if (clickAmount == 3)
        {
            print ("Grattis! Du har klickat 3 gånger.");
        }
    }
}
