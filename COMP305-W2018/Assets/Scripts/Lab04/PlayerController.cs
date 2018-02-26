using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float maxSpeed = 10;
    public float jumpForce = 700f;
    public float groundRadius = 0.2f;
    public Transform groundCheck;
    public LayerMask defineGround;

    private Rigidbody2D rBody;
    private SpriteRenderer sRend;
    private Animator animator;

    private float moveH;
    private bool isRight = true;
    private bool isGrounded = false;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        sRend = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (isGrounded && Input.GetAxis("Jump") > 0)
        {
            animator.SetBool("Ground", false);
            rBody.AddForce(new Vector2(0, jumpForce));
            isGrounded = false;
        }
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, defineGround);
        animator.SetBool("Ground", isGrounded);
        animator.SetFloat("vSpeed", rBody.velocity.y);

        if (isGrounded)
        {
            moveH = Input.GetAxis("Horizontal");
            animator.SetFloat("Speed", Mathf.Abs(moveH));
            rBody.velocity = new Vector2(moveH * maxSpeed, rBody.velocity.y);
            sRend.flipX = moveH < 0;
        }
    }
}
