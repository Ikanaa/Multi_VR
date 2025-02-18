using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerSocleA : MonoBehaviour
{
    public GameObject sabreStatic;
    public GameObject sabreDynamic;
    public animationLerp pont;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == sabreDynamic)
        {
            sabreDynamic.SetActive(false);
            sabreStatic.SetActive(true);
            pont.doAnimation = true;
        }
    }
}
