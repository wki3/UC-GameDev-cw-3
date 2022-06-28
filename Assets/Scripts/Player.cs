using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D playerRb;
    float speed = 6.8f;
    //BoxCollider2D box;
    //Vector2 vector;

    // Start is called before the first frame update

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        //box = GetComponent<BoxCollider2D>()
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerRb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed , 0f);
    }
}
