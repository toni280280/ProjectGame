using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public Texture gameOverTexture;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {

       


            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), gameOverTexture);
            if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 + 30, 150, 25), "Play"))
            {

                Application.LoadLevel("Forrest");

            }
            if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 + 70, 150, 25), "Quit!"))
            {
                Application.Quit();
            }
        
    }
}
