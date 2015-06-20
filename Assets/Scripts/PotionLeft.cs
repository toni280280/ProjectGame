using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PotionLeft : MonoBehaviour {

    public Text potionLeft;

    private PlayerStats PlayerStats;

	
	void Start () {
        PlayerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
        potionLeft = GetComponent<Text>();
	}
	
	
    void OnGUI()
    {
        potionLeft.text = "" + PlayerStats.curPotion;
    }
}
