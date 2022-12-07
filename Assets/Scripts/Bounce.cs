using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{

    public BallMovement BallMovement;
    public ScoreMnager sMnagr;
    public AudioClip BallHit;
    public AudioClip Goal;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
       
    }

    private void ballBounce(Collision2D collision)
    {
        Vector3 Ballposition = transform.position;
        Vector3 racketposition = collision.transform.position;
        float racketHeight = collision.collider.bounds.size.y;

        float positionX;

        if (collision.gameObject.name == "LeftPlayer")
        {
            positionX = 1;
        }
        else
        {
            positionX = 2;
        }

        float positionY = (Ballposition.y - racketposition.y)/racketHeight;

        BallMovement.IncreaseCounter();
        BallMovement.moveBall(new Vector2(positionX, positionY));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name=="RightPlayer"|| collision.gameObject.name == "LeftPlayer")
        {
            GetComponent<AudioSource>().clip = BallHit;
            GetComponent<AudioSource>().Play();
            ballBounce(collision);
        }

        if (collision.gameObject.name == "LeftBorder")
        {
            GetComponent<AudioSource>().clip = Goal;
            GetComponent<AudioSource>().Play();
            sMnagr.RightPlayerGoal();
            BallMovement.LeftPlayerSart = true;
            StartCoroutine(BallMovement.Launch());
        }

        if (collision.gameObject.name == "RightBorder")
        {
            GetComponent<AudioSource>().clip = Goal;
            GetComponent<AudioSource>().Play();
            sMnagr.LeftPlayerGoal();
            BallMovement.LeftPlayerSart = false;
            StartCoroutine(BallMovement.Launch());



        }



    }
}
