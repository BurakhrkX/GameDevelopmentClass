using UnityEngine;

public class BasicCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = 9.81f;
    public float mouseSensitivity = 2f;

    private CharacterController controller;
    private Vector3 velocity;
    private bool isGrounded;
    private float rotationX = 0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
     }

    void Update()
    {
        MovePlayer();
     }

    void MovePlayer()
    {
        isGrounded = controller.isGrounded;

        float moveX = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float moveZ = Input.GetAxis("Vertical");   // W/S or Up/Down
        Debug.Log(" move x" + moveX + "Move Z" + moveZ);

        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        Debug.Log(move);
        controller.Move(move * moveSpeed * Time.deltaTime);

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            velocity.y = jumpForce;
        }

        velocity.y -= gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
 
}
