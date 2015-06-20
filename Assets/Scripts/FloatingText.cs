using UnityEngine;
using System.Collections;

public class FloatingText : MonoBehaviour {

	 
     public float scroll = 0.05f;  
     public float duration = 1.5f; 
     public float alpha;
 
 void Start(){
     
     alpha = 1;
 }
 
 void Update(){
     if (alpha > 0){
         var a = transform.position;
         a.y += scroll*Time.deltaTime;
         transform.position = a; 
         alpha -= Time.deltaTime/duration; 
               
     } else {
         Destroy(gameObject); 
     }
 }
}
