using UnityEngine;
using System.Collections;

public class BoxScript : MonoBehaviour {

    private PlayerMovement PlayerMovement;

	
	void Start () {
        PlayerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
	}
	
	
    void OnCollisionEnter2D(Collision2D coll)
    {
        PlayerMovement.cooldownTime = 13;
        PlayerMovement.time = 0;
    }
    void OnCollisionExit2D(Collision2D coll)
    {
        PlayerMovement.cooldownTime = 6;
        PlayerMovement.time = 0;
    }
}
