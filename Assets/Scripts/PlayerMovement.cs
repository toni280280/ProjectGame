using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour {

    
    Animator anim;
    public float time =  0;
    public float cooldownTime = 2;
    
	

	void Start () {

        
        anim = GetComponent<Animator>();
        
	}
	
	
	void Update () {

        float input_x = Input.GetAxisRaw("Horizontal");
        float input_y = Input.GetAxisRaw("Vertical");

        bool isWalking = (Mathf.Abs(input_x) + Mathf.Abs(input_y)) > 0;

        anim.SetBool("isWalking", isWalking);
        if (isWalking)
        {
            time++;
            if (time == cooldownTime)
            {
                GetComponent<AudioSource>().Play();
                time = 0;
            }
            anim.SetFloat("x", input_x);
            anim.SetFloat("y", input_y);

            transform.position += new Vector3(input_x, input_y, 0).normalized * Time.deltaTime;

            
        }

        
	}
    
}
