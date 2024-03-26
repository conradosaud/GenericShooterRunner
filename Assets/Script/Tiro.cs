using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{

    public float velocidade = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate( -(velocidade * Time.deltaTime) ,0,0);
    }
}
