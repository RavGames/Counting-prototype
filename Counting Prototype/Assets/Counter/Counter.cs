using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Rigidbody))]
public class Counter : MonoBehaviour
{
     
    [SerializeField] float velocityMag; 
    public Text CounterText;

    private int Count = 0;
    private new Rigidbody rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Count = 0;
    }

    
    


    private void OnTriggerEnter(Collider other)
    {
        Count += 1;
        CounterText.text = "Count : " + Count;
    }
}
