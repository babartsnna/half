using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform target;

    void Start()
    {
        
    }

    void Update()
    {
        float dist = Vector3.Distance(transorm.position,target.position);
        if(dist < 6)
        {
            transform.position = new Vector3(transform.position.x,1,transform.position.z);
        }
        else
        {
            transform.localScale = new Vector3(transform.position.x,-2,transform.position.z);
        }
        transform.position = Vector3.Lerp(transform.position,tragetPos,0.05f);
    }
}
