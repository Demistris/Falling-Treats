using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatsFalling : MonoBehaviour
{
    public float fallingSpeed;

    private void Start()
    {
        fallingSpeed = 4;
    }

    void Update()
    {
        transform.position -= transform.up * Time.deltaTime * fallingSpeed;
    }
}
