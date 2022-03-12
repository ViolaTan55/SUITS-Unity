using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionAdjust : MonoBehaviour
{
    void Start()
    {
        transform.position = transform.position + new Vector3(-1,1,0);
    }

    void Update()
    {
        
    }
}
