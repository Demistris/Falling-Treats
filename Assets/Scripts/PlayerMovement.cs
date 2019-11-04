using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerBody;
    private float moveSpeed = 10f;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch(touch.phase)
            {
                case TouchPhase.Began:
                    if(touch.position.x < Screen.width /2)
                    {
                        playerBody.velocity = new Vector2(-moveSpeed, 0f);
                    }

                    if(touch.position.x > Screen.width /2)
                    {
                        playerBody.velocity = new Vector2(moveSpeed, 0f);
                    }
                    break;

                case TouchPhase.Ended:
                    playerBody.velocity = new Vector2(0f, 0f);
                    break;
            }
        }
    }
}
