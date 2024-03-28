using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Run_Inimigo : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        transform.Translate(speed * Time.deltaTime,0,0);  
    }
}
