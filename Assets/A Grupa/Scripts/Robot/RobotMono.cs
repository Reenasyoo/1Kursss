using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMono : MonoBehaviour
{
    public GameObject target;
    public float moveSpeed = 10;
    private Factory factory;
    
    void Update()
    {
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed);
        }
    }

    public void SetTarget(GameObject targ)
    {
        target = targ;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Bullet"))
        {
            factory.UpdateCounter();
            Destroy(gameObject);
        }
    }

    public void SetFactoryReference(Factory fa)
    {
        factory = fa;
    }


}
