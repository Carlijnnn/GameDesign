using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;
    public bool active;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask enemyLayer;
    [SerializeField] private Transform player;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      if (active){
      horizontal = Input.GetAxisRaw("Horizontal");  
      if (Input.GetButtonDown("Jump") && IsGrounded()){
        rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
      }
      if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
      {
        rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
      }
      Flip();
    }
    }

    void FixedUpdate()
    {
      if(active){
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        int LayerEnemy = LayerMask.NameToLayer("Enemy");
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            Vector3 temp = player.position;
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
            if (!(gameObject.layer == LayerEnemy)) {
              if (isFacingRight) {
                player.position = temp - new Vector3(-2,0,0);
              } else {
                player.position = temp - new Vector3(2,0,0);
              }
            }
        }
    }
}
