using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUD : MonoBehaviour {

	public Sprite[] HeartSprites;

    public Image HeartUI;

    private PlayerStats Player;

    void Start() {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
    }
    void Update() {
        HeartUI.sprite = HeartSprites[Player.curHp];
        
    }
}
