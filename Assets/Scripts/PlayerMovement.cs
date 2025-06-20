using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    private Rigidbody2D rb2d;
    private Animator animator;
    [SerializeField] private float WalkSpeed;
    // Start is called before the first frame update
    void Start()
    {
         rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(move* WalkSpeed, rb2d.velocity.y);
        if (move != 0)
        {
            animator.Play("Walk");
            if(move > 0)
            {
                 transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
           
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            Debug.Log("jump");
            animator.Play("Jump");
        }
       else
        {
            animator.Play("Idle");
        }
       
    }

      void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Door")){
            SceneManager.LoadScene(0);
        }

        
         }
}
