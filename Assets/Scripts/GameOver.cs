using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour {

    public Texture gameOverTexture;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnGUI()
    {

        
        //Buttons
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), gameOverTexture);
        if (GUI.Button(new Rect(Screen.width / 2 - 80, Screen.height / 2 + 30, 150, 25), "Restart"))
        {

            Application.LoadLevel("Forrest");

        }
        if (GUI.Button(new Rect(Screen.width / 2 - 80, Screen.height / 2 + 70, 150, 25), "Quit!"))
        {
            Application.Quit();
        }
    }
}
