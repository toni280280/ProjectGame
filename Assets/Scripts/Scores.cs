using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scores : MonoBehaviour {

    public Text scores;

    private PlayerStats PlayerStats;


    void Start()
    {
        PlayerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
        scores = GetComponent<Text>();
    }


    void OnGUI()
    {
        scores.text = "Score: " + PlayerStats.curScores;
    }
}
