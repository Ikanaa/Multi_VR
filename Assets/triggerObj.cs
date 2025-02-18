using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerObj : MonoBehaviour
{
    public GameObject Static;
    public GameObject Dynamic;

    public triggerSocleB socle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Dynamic)
        {
            Dynamic.SetActive(false);
            Static.SetActive(true);
            socle.numberActive += 1;
            socle.testCompl();
        }
    }
}
