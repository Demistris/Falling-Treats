using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatsFalling : MonoBehaviour
{
    private float fallingSpeed;

    private void Start()
    {
        fallingSpeed = 3;
    }

    void Update()
    {
        transform.position -= transform.up * Time.deltaTime * fallingSpeed;
    }
}
