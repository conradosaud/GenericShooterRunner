using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pos : MonoBehaviour
{
    List<float> adap  = new List<float>();
    float p1 = -3.5f;
    float p2 = -1.5f;
    // Start is called before the first frame update
    void Start()
    {
        adap.Add(p1);
        adap.Add(p2);
        StartCoroutine(Teste());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Teste()
    {

        transform.position = new Vector3(transform.position.x, transform.position.y, adap[Random.Range(0,2)]);
        yield return new WaitForSeconds(2);
        StartCoroutine(Teste());
    }
}
