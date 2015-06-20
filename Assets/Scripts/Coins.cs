using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Coins : MonoBehaviour {

    public Text coins;

    private PlayerStats PlayerStats;


    void Start()
    {
        PlayerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
        coins = GetComponent<Text>();
    }


    void OnGUI()
    {
        coins.text = "" + PlayerStats.curCoins;
    }
}
