using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Spikes : MonoBehaviour {

    private PlayerStats PlayerSt;
    public GameObject player;
    public Transform WarpTargetOne;
    public float timeOne = 0;
    public float cooldownTimeOne = 3;
    

    public Transform ptsPrefab;

	// Use this for initialization
	void Start () {
        PlayerSt = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        
        if (coll.gameObject.tag == ("Player") )
        {

            GetComponent<AudioSource>().Play();
            
            PlayerSt.curHp -= 1;
            PlayerSt.curCoins -= 3;
            PlayerSt.curScores -= 15;

            HitCall(-1);
            
            
        }
    }
    void OnTriggerStay2D(Collider2D coll)
    {

        if (coll.gameObject.tag == ("Player") )
        {

            timeOne++;
            if (timeOne == cooldownTimeOne)
            {
                GetComponent<AudioSource>().Play();

                PlayerSt.curHp -= 1;
                PlayerSt.curCoins -= 3;
                PlayerSt.curScores -= 15;


                HitCall(-1);
                

                timeOne = 0;
            }
            


        }
    }
     void SpawnPts(float points,float x,float  y)
     {
            x = Mathf.Clamp(x,0.05f,0.95f); // clamp position to screen to ensure
            y = Mathf.Clamp(y,0.05f,0.9f);  // the string will be visible
            
            Transform gui = Instantiate(ptsPrefab,new Vector3(x, y, 0), Quaternion.identity) as Transform;

            gui.GetComponent<GUIText>().text = points.ToString();
     }
     void HitCall(float p)
     {
         
             SpawnPts(p, 0.5f, 0.58f);
         

     }
     
}
