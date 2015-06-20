using UnityEngine;
using System.Collections;

public class WinScreen : MonoBehaviour {
    private PlayerStats PlayerSt;



    void Start()
    {
        PlayerSt = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
    }
    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.tag == "Player")
        {
            PlayerPrefs.SetInt("FinalScore",PlayerSt.curScores);
            PlayerPrefs.SetInt("FinalPotion", PlayerSt.curPotion);
            PlayerPrefs.SetInt("FinalCoins", PlayerSt.curCoins);
            PlayerPrefs.SetInt("FinalHp", PlayerSt.curHp);
            Application.LoadLevel("WinScreenScene");
        }
    }
}
