using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwipeMovement : MonoBehaviour
{
    private Vector3 touchPosition;
    private Vector3 direction;
    private Rigidbody2D rb;
    private float moveSpeed = 20f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, 0) * moveSpeed;

            if(touch.phase == TouchPhase.Ended)
            {
                rb.velocity = Vector2.zero;
            }
        }
    }
}
