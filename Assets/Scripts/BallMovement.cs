using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    
    public float speed = 2.0f;
    public float jumpForce = 10.0f;
    private Rigidbody rb;
    bool isGrounded;

    public Camera cam;
    public float dirRotate = -15.0f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void FixedUpdate(){
        // float movementHorizontal = Input.GetAxis("Horizontal");
        // float movementVertical = Input.GetAxis("Vertical");

        // Vector3 movement = new Vector3 (movementHorizontal, 0.0f, movementVertical);

        Vector3 direction = Quaternion.Euler(dirRotate, 0, 0) * cam.transform.forward;
        // Debug.Log("CAMCAM: " + cam.transform.forward);
        // Debug.Log("KEMKOM: " + newPos);
        if(Input.GetAxis("Vertical") > 0) {
            rb.AddForce(direction * speed);
        } 
        if(Input.GetAxis("Vertical") < 0) {
            rb.AddForce(direction * speed * -1);
        }

        if(Input.GetAxis("Horizontal") > 0) {
            rb.AddForce(cam.transform.right * speed);
        } 
        if(Input.GetAxis("Horizontal") < 0) {
            rb.AddForce(cam.transform.right * speed * -1);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
    
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }  
    }

    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
