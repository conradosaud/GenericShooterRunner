using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{

    public Transform prefabTiro;
    public Transform containerTiro;
    public float intervaloTiro = 0.5f;

    void Start()
    {
        //containerTiro = GameObject.Find("ContainerTiro").transform;
        Atirar();
    }

    void Atirar()
    {
        Transform tiro = Instantiate(prefabTiro);
        tiro.position = transform.position;
        tiro.parent = containerTiro;

        Invoke("Atirar", intervaloTiro);
    }

}
