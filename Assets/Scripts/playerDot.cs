using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDot : Dot
{


    void Start()
    {
        base.Start();
        transform.position = new Vector3(0, 0, 0);
    }


}
