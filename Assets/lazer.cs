using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class lazer : MonoBehaviour
{

    public Transform start;
    public Transform end;

    public GameObject player;
    public Transform teleportPos;

    public LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer.SetPositions(new Vector3[] { start.position, end.position });
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(start.position, (end.position - start.position).normalized, out hit, Vector3.Distance(start.position, end.position)))
        {
            if (hit.transform.gameObject == player)
            {
                player.transform.position = teleportPos.position;
                lineRenderer.SetPositions(new Vector3[] { start.position, end.position });
                return;
            }
            lineRenderer.SetPositions(new Vector3[] { start.position, hit.transform.position });
        }
        else
        {
            lineRenderer.SetPositions(new Vector3[] { start.position, end.position });
        }
    }
}
