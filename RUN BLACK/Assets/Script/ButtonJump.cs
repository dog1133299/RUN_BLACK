using UnityEngine;
using System.Collections;

public class ButtonJump : MonoBehaviour
{
    private bool isJumping = false;
    private bool isGround = false;
    private Rigidbody2D body;
    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        SetJumpState();
    }

    void Update()
    {
    }

    public void onClick() {
        body.velocity = new Vector2(0F, 12F);
        Camera.main.SendMessage("sound", 4);
    }
    void SetJumpState() {
        if (body.velocity.y > 0.1) {
            isJumping = true;
            isGround = false;
            
        }
        else if (isJumping) {
            isJumping = false;
        }
    }
}