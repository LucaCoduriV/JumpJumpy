using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalMovement = 0;
    private bool isJumping = false;
    [SerializeField]
    private float speed = 10;
    [SerializeField]
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            animator.SetBool("isJumping", true);
        }

        animator.SetFloat("speed", Mathf.Abs(horizontalMovement));
        
    }

    public void onLanding()
    {
        animator.SetBool("isJumping", false);
    }

    private void FixedUpdate()
    {
        GetComponent<CharacterController2D>().Move(horizontalMovement * Time.fixedDeltaTime * speed, false, isJumping);
        isJumping = false;
    }

}
