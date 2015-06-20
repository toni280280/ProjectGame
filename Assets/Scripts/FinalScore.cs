using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour {

    public Text finalScore;

    private PlayerStats PlayerStats;
    public int someScore;

    public Texture gameOverTexture;
	
	void Start () {
        PlayerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
        finalScore = GetComponent<Text>();
        
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnGUI()
    {
        

        

        int score = PlayerPrefs.GetInt("FinalScore");
        int potion = PlayerPrefs.GetInt("FinalPotion");
        int coins = PlayerPrefs.GetInt("FinalCoins");
        int life = PlayerPrefs.GetInt("FinalHp");
        someScore = (coins * 18) + (potion * 20) + (life * 25) + score;
        GetComponent<Text>().text = "Scores: " + someScore;


        //Buttons
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), gameOverTexture);
        if (GUI.Button(new Rect(Screen.width / 2 - 80, Screen.height / 2 + 30, 150, 25), "Restart"))
        {

            Application.LoadLevel("Forrest");

        }
        if (GUI.Button(new Rect(Screen.width / 2 - 80, Screen.height / 2 + 70, 150, 25), "Quit"))
        {
            Application.Quit();
        }
        

    }
    
}
