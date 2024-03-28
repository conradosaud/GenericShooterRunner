using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{

    public float velocidade = 5f;
    public float tempoDestruir = 3.5f;

    private void Start()
    {
        Invoke("Destruir", tempoDestruir);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( -(velocidade * Time.deltaTime) ,0,0);
    }

    void Destruir()
    {
        Destroy(gameObject);
    }

}
