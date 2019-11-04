using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public GameObject Player;

    private Rigidbody2D playerBody;
    private float screenWidth;

    void Start()
    {
        screenWidth = Screen.width;
        playerBody = Player.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        int i = 0;
        //loop over every touch found
        while(i < Input.touchCount)
        {
            if(Input.GetTouch(i).position.x > screenWidth / 2)
            {
                //move right
                RunPlayer(1.0f);
            }
            if(Input.GetTouch(i).position.x < screenWidth / 2)
            {
                //move left
                RunPlayer(-1.0f);
            }
            ++i;
        }
    }

    void FixedUpdate()
    {
        #if UNITY_EDITOR
        RunPlayer(Input.GetAxis("Horizontal"));
        #endif
    }

    private void RunPlayer(float horizontalInput)
    {
        //move player
        playerBody.AddForce(new Vector2(horizontalInput * MoveSpeed + Time.deltaTime, 0));
    }
}
