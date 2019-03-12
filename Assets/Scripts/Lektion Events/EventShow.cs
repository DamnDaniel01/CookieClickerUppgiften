using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventShow : MonoBehaviour
{
    public event Action Godmorgon;

    // Start is called before the first frame update
    void Start()
    {
        Godmorgon += YlvaSägHej;
        Godmorgon += GustavVinka;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Godmorgon.Invoke();
        }
    }

    public void YlvaSägHej ()
    {
        print("Hej");
    }

    public void GustavVinka ()
    {
        print("Vink vink");
    }
}
