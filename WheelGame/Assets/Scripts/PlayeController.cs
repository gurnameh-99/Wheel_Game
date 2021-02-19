using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeController : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed = 5f;
    public float turnSpeed = 20f;
    
    private Vector3 direction = new Vector3(0f,0f,1f);

    // Update is called once per frame
    void Update()
    {
        controller.Move(direction * moveSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(100, 0, 0) * Time.deltaTime);
    }
}
