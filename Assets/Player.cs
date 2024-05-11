using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float jump = 300f;

    Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown( KeyCode.W ) )
        {
            rbody.AddForce( transform.up * jump );
        }
    }

    private void FixedUpdate()
    {
        rbody.velocity = new Vector2( speed, rbody.velocity.y );
    }
}
