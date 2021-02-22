using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeController : MonoBehaviour
{
    public Rigidbody rb;
    public float max_speed;
    public float torque;
    private Vector3 change;


    void Start()
    {
        /*game = GetComponent<GameObject>();*/
        rb = GetComponent<Rigidbody>();
        change = new Vector3(0f, 0.1f, 0.1f);
    }

    void FixedUpdate()
    {
        float speed = rb.velocity.sqrMagnitude;
        if(speed < max_speed)
        {
            rb.AddTorque(transform.right * torque);
        }
        if (Input.GetButton("Jump"))
        {
            if (gameObject.transform.localScale.y < 2.5)
            {
                gameObject.transform.localScale += change;
                gameObject.transform.localPosition += new Vector3(0f, 0.2f, 0f);
            }
        }
        else
        {
            gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            
        }
        
    }
}
