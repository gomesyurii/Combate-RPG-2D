using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDot : Dot
{

    private float randomX;

    void Start()
    {
        //randomizar posicao x
        base.Start();
        randomX = Random.Range(-4.5f, 4.5f);
        transform.position = new Vector3(randomX, 0, 0);

    }


}
