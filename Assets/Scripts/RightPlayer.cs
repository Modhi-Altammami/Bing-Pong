using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPlayer : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;
    private Vector2 racketDirection;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame like timers and input detection
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical2");

        racketDirection = new Vector2(0, directionY).normalized;

    }

    // fixedUpdate is called once per physics frame like rigidbody
    void FixedUpdate()
    {
        rb.velocity = racketDirection * speed;
    }
}
