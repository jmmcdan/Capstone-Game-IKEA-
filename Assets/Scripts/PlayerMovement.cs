using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveForce = 2f;
    private Rigidbody rb;
    float rotationX = 0f;
    float rotationY = 0f;
    public float sensitivity = 15f;
    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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

        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        //rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0f);
    }
}
