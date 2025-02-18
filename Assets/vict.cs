using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vict : MonoBehaviour
{
    public GameObject player;
    public GameObject ui;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            ui.SetActive(true);
        }
    }
}
