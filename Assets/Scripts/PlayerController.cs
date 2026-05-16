using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [HideInInspector] public float mx;
    [HideInInspector] public float my;
    private Rigidbody rb;
    [SerializeField] private float speed = 10f;
    private Camera playerCamera;
    [SerializeField] private float jumpForce;
    [SerializeField] private bool isGround;
    private bool isJumping;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerCamera = Camera.main;
    }

    void Update()
    {

    }
    #region entradasteclado
    void OnMove(InputValue movementvalue)
    {
        Vector2 movement = movementvalue.Get<Vector2>();
        mx = movement.x;
        my = movement.y;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            isGround = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {

        if (collision.transform.CompareTag("Ground"))
        {
            isGround = false;
        }
    }


    void OnJump()
    {

        isJumping = true;


    }
    #endregion
    void FixedUpdate()
    {
        Vector3 cameraForward = playerCamera.transform.forward;
        Vector3 cameraRight = playerCamera.transform.right;
        cameraForward.y = 0;
        cameraRight.y = 0;

        cameraForward.Normalize();
        cameraRight.Normalize();

        Vector3 movementDirection = (cameraForward * my) + (cameraRight * mx);
        rb.AddForce(movementDirection * speed);

        if (isJumping == true)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = false;
        }



    }

}






































































































































































































































































































































































































































































