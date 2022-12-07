using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float StartSpeed;
    public float MaxSpeed;
    public float ExtraSpeed;
    public bool LeftPlayerSart = true;

    private int Counter = 0;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       StartCoroutine(Launch());
    }

    private void restartBall()
    {
        rb.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);

    }

    public IEnumerator Launch(){
        restartBall();
        Counter = 0;
        yield return new WaitForSeconds(1);
        if(LeftPlayerSart==true)
        moveBall(new Vector2(-1, 0));
        else
            moveBall(new Vector2(1, 0));
    }

    public void moveBall(Vector2 direction)
    {
        direction = direction.normalized;
        float ballspeed = StartSpeed + ExtraSpeed * Counter;
        rb.velocity = direction * ballspeed;

    }


    public void IncreaseCounter()
    {
        if (Counter * ExtraSpeed < MaxSpeed)
        {
            Counter++;

        }
    }
}
