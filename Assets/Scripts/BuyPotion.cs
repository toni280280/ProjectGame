using UnityEngine;
using System.Collections;

public class BuyPotion : MonoBehaviour {


    public Transform ptsPrefab;
    private PlayerStats PlayerSt;
	
    // Use this for initialization
	void Start () {
        PlayerSt = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerStay2D(Collider2D coll)
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (PlayerSt.curCoins >= 10)
            {
                GetComponent<AudioSource>().Play();
                PlayerSt.curPotion += 1;
                PlayerSt.curCoins -= 10;
                HitCall(-10);
            }
            

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
