using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove2 : MonoBehaviour
{

    float velocidade = 6.5f;

    public VariableJoystick variableJoystick;

    Vector3 posicao1;
    Vector3 posicao2;

    Vector3 novaPosicao;

    private void Start()
    {
        posicao1 = new Vector3(0, 0.5f, -3.5f);
        posicao2 = new Vector3(0, 0.5f, -1.5f);
        transform.position = posicao1;
    }

    private void Update()
    {
        if( Input.GetAxis("Horizontal") > 0 || variableJoystick.Horizontal > 0 )
        {
            novaPosicao = posicao2;
        }
        if(Input.GetAxis("Horizontal") < 0 || variableJoystick.Horizontal < 0 )
        {
            novaPosicao = posicao1;
        }

        transform.position = Vector3.Lerp(transform.position, novaPosicao, Time.deltaTime * velocidade);
    }


}
