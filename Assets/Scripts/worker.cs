using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worker : MonoBehaviour
{
   public Transform a;
   public Transform b;

    private CharacterController controller;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = (a.position + b.position) / 2;
    }
}
