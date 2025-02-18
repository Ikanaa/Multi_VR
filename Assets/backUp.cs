using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backUp : MonoBehaviour
{

    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0.3)
        {
            transform.position = pos;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
}
