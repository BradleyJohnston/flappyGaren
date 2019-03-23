using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSetting : MonoBehaviour
{
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        Vector3 buffer = rb.transform.position;
        Vector3 current = transform.position;

        if (buffer.x - current.x > 10)
        {
            transform.position = new Vector3(
                buffer.x + 10, current.y, current.z);
        }
        
    }
}
