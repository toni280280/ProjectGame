using System;
using UnityEngine;
public class Pause : MonoBehaviour {

    float TS;
    bool paused = false;
    public Texture gameOverTexture;
    private BackgroundMusic music;

    

    void Start()
    {
        TS = Time.timeScale;
        
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (!paused)
            {
                paused = true;
            }
            else
            {
                paused = false;
            }
        }
        if (paused)
        {
            if (Time.timeScale > 0)
            {
                Time.timeScale = 0.0f;

            }
            else
            {
                GetComponent<AudioSource>().Pause();
                
            }
        }
        else
        {
            if (Time.timeScale < TS)
            {
                Time.timeScale = 1;
            }
            if (GetComponent<AudioSource>().pitch < 1) {
                if (!GetComponent<AudioSource>().isPlaying) {
                    GetComponent<AudioSource>().Play();
                    
                }
                
            }
        }
    }
    
    void OnGUI()
    {
        
        if (paused)
        {

            
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), gameOverTexture);
            if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 + 30, 150, 25), "Resume!"))
            {
                paused = false;
                
                
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 + 70, 150, 25), "Quit!"))
            {
                Application.Quit();
            }
        }
    }
    
}

