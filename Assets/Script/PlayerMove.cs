using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float velocidade = 6.5f;
    
    Vector3 posicao1;
    Vector3 posicao2;

    Vector3 newPosition;
    public VariableJoystick variableJoystick;


    void Start()
    {
        posicao1 = new Vector3(0, 0.5f, -1.5f);
        posicao2 = new Vector3(0, 0.5f, -3.5f);

        transform.position = posicao1;
        newPosition = posicao1;

    }

    void Update()
    {

        float horizontal;

        if (Input.GetAxis("Horizontal") > 0 || variableJoystick.Horizontal > 0)
        {
            newPosition = posicao1;
        }
        if (Input.GetAxis("Horizontal") < 0 || variableJoystick.Horizontal < 0)
        {
            newPosition = posicao2;
        }

        transform.position = Vector3.Lerp(transform.position, newPosition, velocidade * Time.deltaTime);

    }
}
