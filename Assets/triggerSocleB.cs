using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerSocleB : MonoBehaviour
{
    public animationLerp pont;

    public int numberActive = 0;


    public void testCompl()
    {
        if (numberActive >= 3)
        {
            pont.doAnimation = true;
        }
    }
}
