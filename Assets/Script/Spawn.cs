using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject inimigo;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawner());
    }

    IEnumerator spawner()
    {
        yield return new WaitForSeconds(timer);
        GameObject novo_Inimigo = Instantiate(inimigo, transform.position, Quaternion.identity);
        StartCoroutine(spawner());
    }
}
