using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;

    [Range(0, 500)] public int moveSpeed = 10;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        Vector3 inputDirections = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));

        playerRigidbody.AddForce(inputDirections * moveSpeed);
        
        // if (inputDirections != Vector2.zero) // Vector2.zero == new Vector2(0,0);
        // {
        //     print(inputDirections);
        // }
    }
}
