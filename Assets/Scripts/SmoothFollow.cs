using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 5, -10));
        transform.position = target.position;
            // Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
