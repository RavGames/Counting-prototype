using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    [SerializeField][Range(2f,12f)] private float speed;
    [SerializeField]private float length;
    

    
    private void Update() {
      
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed,length),transform.position.y,transform.position.z); 
    }

    



}//CLASS
