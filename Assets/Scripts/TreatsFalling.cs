using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatsFalling : MonoBehaviour
{
    public static float fallingSpeed = 4;

    void Update()
    {
        transform.position -= transform.up * Time.deltaTime * fallingSpeed;

        ref int counter = ref PlayerStats.Instance.DifficulteIncreaseCounter;

        if (counter == 10)
        {
            fallingSpeed += 0.5f;
            counter = 0;
            Debug.Log(fallingSpeed);
        }
    }
}
