using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatsThrower : MonoBehaviour
{
    public GameObject[] Treat;
    private int typeOfTreat;
    private float timer;
    private int throwerDiamondCounter;

    void Start()
    {
        StartCoroutine(CountdownTreats());
    }

    IEnumerator CountdownTreats()
    {
        timer = Random.Range(0.1f, 1f);
        typeOfTreat = Random.Range(0, 5);
        throwerDiamondCounter = Random.Range(1, 21);
        Vector2 randomSpawn = new Vector2(Random.Range(-2.5f, 2.5f), gameObject.transform.position.y);

        if(throwerDiamondCounter == 5)
        {
            Instantiate(Treat[5], randomSpawn, transform.rotation, gameObject.transform);
        }
        else
        {
            Instantiate(Treat[typeOfTreat], randomSpawn, transform.rotation, gameObject.transform);
        }

        yield return new WaitForSeconds(timer);
        StartCoroutine(CountdownTreats());
    }
}
