using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float moveSpeed = 5f;

    [Header("Jump")]
    [SerializeField] private float jumpForce = 10f;

    [Header("Ground Check")]
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundCheckRadius = 0.2f;
    [SerializeField] private LayerMask groundLayer;

    private Rigidbody2D rb;

    private float horizontalInput;
    private bool jumpRequested;
    private bool isGrounded;
    public gameLogic logic;
    private bool isBirdAlive = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        isBirdAlive = true;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<gameLogic>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");

        isGrounded = Physics2D.OverlapCircle(
            groundCheck.position,
            groundCheckRadius,
            groundLayer
        );

        if (Input.GetButtonDown("Jump") && isGrounded )
        {
            jumpRequested = true;
        }
    }

    private void FixedUpdate()
    {
        if (isBirdAlive)
        {
            rb.velocity = new Vector2(
                horizontalInput * moveSpeed,
                rb.velocity.y
                );
        }

        if (jumpRequested )
        {
            rb.velocity = new Vector2(
                rb.velocity.x,
                jumpForce
            );

            jumpRequested = false;
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (groundCheck == null)
            return;

        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(
            groundCheck.position,
            groundCheckRadius
        );
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7 || collision.gameObject.layer == 8)
        {
            Destroy(collision.gameObject);
            logic.gameOver();
            isBirdAlive = false;   
        }
    }

}