using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatsThrower : MonoBehaviour
{
    public GameObject Treat;
    private float timer;

    void Start()
    {
        StartCoroutine(CountdownTreats());
    }

    IEnumerator CountdownTreats()
    {
        timer = Random.Range(0.1f, 2f);
        Vector2 randomSpawn = new Vector2(Random.Range(-2.5f, 2.5f), gameObject.transform.position.y);
        Instantiate(Treat, randomSpawn, transform.rotation, gameObject.transform);

        yield return new WaitForSeconds(timer);
        StartCoroutine(CountdownTreats());
    }
}
