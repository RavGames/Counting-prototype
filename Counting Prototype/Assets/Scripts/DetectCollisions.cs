using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    [SerializeField] private float delay;

    [SerializeField] private float gravityFallMultiplier;
    Rigidbody rigidbody;

    private void Start() 
    {
        Physics.gravity *= gravityFallMultiplier;
        rigidbody = GetComponent<Rigidbody>();
        
    }
    
    private void Update() {
        //FallingGravity();
        
    }


    private void FallingGravity()
    {
        Vector3 gravity = Physics.gravity.y * Vector3.up;
        
        rigidbody.AddForce(gravity * gravityFallMultiplier, ForceMode.Acceleration);
        
        
        
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("ground"))
        {
            StartCoroutine(Deactivate());
            
        }
    }
    // void OnTriggerEnter(Collider other)
    // {
    //     // Instead of destroying the projectile when it collides with an animal
    //     //Destroy(other.gameObject); 

    //     // Just deactivate the food and destroy the animal
        
        
    //     // Destroy(gameObject);
    // }


    IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(delay);
        Debug.Log("started");
        Quaternion rot = Quaternion.identity;
        transform.rotation = rot;
        gameObject.SetActive(false);
    }

}
