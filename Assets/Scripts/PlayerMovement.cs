using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 2f;
    private Rigidbody rb;
    float rotationX = 0f;
    float rotationY = 0f;
    private Vector3 moveDirection;
    public float sensitivity = 2f;
    public Transform cameraTransform;
    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        rotationY = transform.eulerAngles.y;
    }
    // Update is called once per frame
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX -= Input.GetAxis("Mouse Y") * sensitivity;
        rotationX = Mathf.Clamp(rotationX, -85f, 85f);

        transform.rotation = Quaternion.Euler(0f, rotationY, 0f);

        if (cameraTransform != null)
            cameraTransform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);

        moveDirection = Vector3.zero;
        if (Input.GetKey(KeyCode.W)) moveDirection += transform.forward;
        if (Input.GetKey(KeyCode.S)) moveDirection -= transform.forward;
        if (Input.GetKey(KeyCode.D)) moveDirection += transform.right;
        if (Input.GetKey(KeyCode.A)) moveDirection -= transform.right;
        moveDirection = moveDirection.normalized;
    }

    void FixedUpdate()
    {
        Vector3 velocity = moveDirection * moveSpeed;
        velocity.y = rb.velocity.y;
        rb.velocity = velocity;
    }
}