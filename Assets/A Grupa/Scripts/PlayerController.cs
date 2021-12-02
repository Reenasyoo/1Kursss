using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;

    [Range(0, 500)] public int moveSpeed = 10;
    [Range(0, 10)] public int lookSpeed = 1;
    [Range(0, 10000)] public int power = 1;

    public GameObject bulletPrefab;
    public Transform targetPos;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        Vector3 inputDirections = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
        Vector3 velocity = transform.TransformDirection(inputDirections);
        velocity *= moveSpeed * Time.deltaTime;
        velocity.y = playerRigidbody.velocity.y;
        playerRigidbody.velocity = velocity;
        
        // if (inputDirections != Vector2.zero) // Vector2.zero == new Vector2(0,0);
        // {
        //     print(inputDirections);
        // }
        LookAround();
    }

    private void LookAround()
    {
        if (Input.GetAxis("Mouse X") < 0)
        {
            transform.Rotate(Vector3.up * -lookSpeed);
        }
        
        if (Input.GetAxis("Mouse X") > 0)
        {
            transform.Rotate(Vector3.up * lookSpeed);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, targetPos.position, targetPos.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * power);
        
        Destroy(bullet, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
