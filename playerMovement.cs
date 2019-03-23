using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class playerMovement : MonoBehaviour
{
   // public BoxColider safe;
    public Rigidbody rb;
    public int jumpHeight;
    public float horizontalMovement;
    public int gravity;

    private bool isAlive;

    void Start()
    {
        isAlive = true;
        rb.velocity = new Vector3(horizontalMovement, jumpHeight, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && isAlive)
        {
            rb.velocity = new Vector3(horizontalMovement, jumpHeight, 0);
        }
        else if (isAlive)
        {
            rb.velocity = new Vector3(horizontalMovement,
                rb.velocity.y,
                rb.velocity.z);
        }
        else
        {
            Vector3 velo = rb.velocity;
            rb.velocity = new Vector3(0, velo.y, 0);

            if (Input.GetKeyDown("r"))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }

        Vector3 vel = rb.velocity;
        Vector3 rotate = new Vector3(0, 0, 0);

        rotate.z = Mathf.Lerp(30, -80, -vel.y / horizontalMovement);

        rb.transform.eulerAngles = rotate;

        horizontalMovement *= 1.0001f;
    }

    void FixedUpdate()
    {
        rb.AddForce(0, -gravity, 0);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name != "ceiling")
        {
            isAlive = false;
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
