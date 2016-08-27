using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

    Text text;
    ScoreAbsorber absorber;
	// Use this for initialization
	void Start () {

        text = GetComponent<Text>();
        absorber = FindObjectOfType<ScoreAbsorber>();
        text.text = "Score: " + absorber.score;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
