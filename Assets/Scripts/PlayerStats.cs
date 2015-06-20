using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerStats : MonoBehaviour {

    public int curPotion = 1;
	public int curHp;
    public int maxHp = 5;
    public int curScores;
    public int curCoins;
    
    
    

	void Start () {
        curHp = maxHp;
        
	}
	
	// Update is called once per frame
	void Update () {

        if (curCoins < 0)
        {
            curCoins = 0;
        }
        if (curScores< 0)
        {
            curScores = 0;
        }
        if (curHp > maxHp)
        {
            curHp = maxHp;
        }
        if (curHp <= 0)
        {
            Die();
        }
        
        if (curPotion < 0)
        {
            curPotion = 0;
        }

        
	}
    void Die(){
        Application.LoadLevel("GameOver");
    }
    
}
