using UnityEngine;
using System.Collections;

public class TriggerDoor : MonoBehaviour {

    public GameObject rockUp;
    public GameObject rockDown;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        var a = rockUp.transform.position;
        a.y += 16f * Time.deltaTime;
        rockUp.transform.position = a;
        var b = rockDown.transform.position;
        b.y -= 16f * Time.deltaTime;
        rockDown.transform.position = b;
    }
    void OnTriggerExit2D(Collider2D col)
    {
        var a = rockDown.transform.position;
        a.y -= 16f * Time.deltaTime;
        rockDown.transform.position = a;
        var b = rockDown.transform.position;
        b.y += 16f * Time.deltaTime;
        rockDown.transform.position = b;
    }
}
