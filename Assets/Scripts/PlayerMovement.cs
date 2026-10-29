using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveForce = 0.2f;
    private Rigidbody rb;   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("No Rigidbody attached to " + gameObject.name + ". PlayerMovement requires a Rigidbody component.");
        }
}

    // Update is called once per frame
    void Update()
    {
        Vector3 force = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            force += transform.forward;
        if (Input.GetKey(KeyCode.S))
            force -= transform.forward;
        if (Input.GetKey(KeyCode.A))
            force -= transform.right;
        if (Input.GetKey(KeyCode.D))
            force += transform.right;

        if (force != Vector3.zero && rb != null)
            rb.AddForce(force.normalized * moveForce);
    }
}
