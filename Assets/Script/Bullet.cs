using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float velocidade = 5f;
    public float tempoVida = 3f;

    void Start()
    {
        Invoke("DestruirBala", tempoVida);
    }

    void Update()
    {
        transform.Translate( -(velocidade * Time.deltaTime) , 0, 0 );
    }

    void DestruirBala()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "inimigo")
        {
            Debug.Log("Colidiu");
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

}
