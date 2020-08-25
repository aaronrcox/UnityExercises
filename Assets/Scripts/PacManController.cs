using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManController : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    Vector3 dir = Vector3.zero;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) dir = Vector3.left;
        if (Input.GetKeyDown(KeyCode.RightArrow)) dir = Vector3.right;
        if (Input.GetKeyDown(KeyCode.UpArrow)) dir = Vector3.forward;
        if (Input.GetKeyDown(KeyCode.DownArrow)) dir = Vector3.back;

        rb.velocity = dir * moveSpeed;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "PacDot")
        {
            Destroy(collision.gameObject);
        }
    }
}
