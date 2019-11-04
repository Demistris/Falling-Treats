using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatsThrower : MonoBehaviour
{
    public GameObject Treat;
    public Transform TreatThrower;

    void Start()
    {
        StartCoroutine(CountdownTreats());
    }

    IEnumerator CountdownTreats()
    {
        Instantiate(Treat, transform.position, transform.rotation, TreatThrower);
        yield return new WaitForSeconds(5);
        StartCoroutine(CountdownTreats());
    }
}
