using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public Transform prefabTiro;
    public float intervaloTiro = 0.5f;

    void Start()
    {
        Atirar();
    }

    void Atirar()
    {
        Transform instancia = Instantiate(prefabTiro);
        instancia.position = transform.position;
        instancia.rotation = transform.rotation;
        Invoke("Atirar", intervaloTiro);
    }

}
