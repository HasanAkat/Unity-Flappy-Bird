using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public float velocity;

    private void Start()
    {
        Destroy(gameObject, 6);
    }

    void FixedUpdate()
    {
        transform.position += Vector3.left * velocity * Time.deltaTime;
        
    }
}
