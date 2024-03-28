using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public Transform prefabTiro;
    public Transform containerTiros;
    public float intervaloTiro = 0.5f;

    void Start()
    {
        containerTiros = GameObject.Find("ContainerTiros").transform;
        Atirar();
    }

    void Atirar()
    {
        Transform instancia = Instantiate(prefabTiro, containerTiros);
        instancia.position = transform.position;
        instancia.rotation = transform.rotation;
        Invoke("Atirar", intervaloTiro);
    }

}
