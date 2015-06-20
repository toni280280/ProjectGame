using UnityEngine;
using System.Collections;

public class CoinPickUp : MonoBehaviour {

    public Transform ptsPrefab;

    private PlayerStats PlayerSt;
    

	// Use this for initialization
	void Start () {
        PlayerSt = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == ("Player"))
        {


            PlayerSt.curCoins += 1;
            PlayerSt.curScores += 10;
            HitCall(1);
            
            GetComponent<AudioSource>().Play();
            Destroy(this.gameObject.GetComponent<Collider2D>());
            Destroy(this.gameObject.GetComponent<Renderer>());
            Destroy(this.gameObject , 0.2f);
            
        }
    }
    void SpawnPts(float points, float x, float y)
    {
        x = Mathf.Clamp(x, 0.05f, 0.95f); // clamp position to screen to ensure
        y = Mathf.Clamp(y, 0.05f, 0.9f);  // the string will be visible

        Transform gui = Instantiate(ptsPrefab, new Vector3(x, y, 0), Quaternion.identity) as Transform;

        gui.GetComponent<GUIText>().text = points.ToString();
    }
    void HitCall(float p)
    {
        
            SpawnPts(p, 0.5f, 0.58f);
        
        
    }
}
