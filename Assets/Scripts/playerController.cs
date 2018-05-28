using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour {

    // Reference to the RigidBody
    public Rigidbody RigidBody;
    // Movement Speed
    public float Speed = 800;
    // How fast it accelerates and stops
    public float Snappiness = 18;
    // Force when jumping
    public float JumpHeight = 60;
    // Speed of fastfall
    public float FastFallSpeed = 100;
    // Jumps since last touching ground
    float JumpsSinceGrounded;
    // Has the player finished jumping
    bool JumpFinished = true;
    // Has the player finished FastFalling
    bool FastFallFinished = true;

    void FixedUpdate() {
        //Horizontal movement
        RigidBody.AddForce(new Vector3((Input.GetAxis("Horizontal") * Speed) - RigidBody.velocity.x * Snappiness, 0, 0));

        // Jump
        if (Input.GetAxisRaw("Jump") > 0.5 && JumpsSinceGrounded <= 1 && JumpFinished)
        {
            // Add jump force
            RigidBody.AddForce(new Vector3(0, JumpHeight, 0), ForceMode.Impulse);
            // Set velocity to zero to make double jumps work
            RigidBody.velocity = Vector3.zero;
            // Add one to JumpsSinceGrounded
            JumpsSinceGrounded += 1;
            // Set JumpFinished to false
            JumpFinished = false;
        }
        // Set JumpFinished to false if jump key is not touched
        if (Input.GetAxisRaw("Jump") < 0.5) { JumpFinished = true; }
        // FastFall
        if (Input.GetAxisRaw("Fall") > 0.95)
        {
            // Set velocity to down
            RigidBody.velocity = new Vector3(RigidBody.velocity.x, FastFallSpeed * -1, 0);
            // Set FastFallFinished to false
            FastFallFinished = false;
        }
        // FastFall key not touched
        if (Input.GetAxisRaw("Fall") < 0.95 && FastFallFinished == false) {
            // Set FastFallFinished to true
            FastFallFinished = true;
            // Return velocity to max
            RigidBody.velocity = new Vector3(RigidBody.velocity.x, -55, 0);
        }
        
        // Reloads the scene if the player is under y = 25
        if (transform.position.y <= -25)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

     void OnCollisionEnter(Collision c)
     {
        //  Is player touching ground
        if (c.gameObject.tag == "Ground")
        {
            // Where is player touching ground
            var normal = c.contacts[0].normal;
            // Is player touching top of ground
            if (normal.y > 0)
            {
                // Return JumpsSinceGrounded to 0
                JumpsSinceGrounded = 0;
            }
            }
     }
}
