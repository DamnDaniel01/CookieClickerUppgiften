using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEvents : MonoBehaviour
{
    public Action TestEvent;

    //public Func<int> SpeedIncrease;

    public void Move() { }

    // Start is called before the first frame update
    void Start()
    {
        TestEvent = Move;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
