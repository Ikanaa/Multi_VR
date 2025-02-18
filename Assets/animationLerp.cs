using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class animationLerp : MonoBehaviour
{

    public Vector3 positionTarget;
    private Vector3 positionStart;
    public float timeToReachTarget = 1.0f;
    public bool doAnimation = false;
    private float t;


    private void Start()
    {
        positionStart = transform.localPosition;
    }

    // Update is called once per frame
    private void Update()
    {
        if (doAnimation && positionTarget != positionStart)
        {
            t += Time.deltaTime / timeToReachTarget;
            transform.localPosition = Vector3.Lerp(positionStart, positionTarget, t);
        }
    }
}
