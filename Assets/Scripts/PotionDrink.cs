using UnityEngine;
using System.Collections;

public class PotionDrink : MonoBehaviour {

    private PlayerStats PlayerSt;
    public Transform ptsPrefab;
    void Start() {
        PlayerSt = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Tab) && PlayerSt.curPotion > 0 && PlayerSt.curHp < 5)
        {
            GetComponent<AudioSource>().Play();
            PlayerSt.curHp += 1;
            PlayerSt.curPotion -= 1;
            HitCall(1);

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
