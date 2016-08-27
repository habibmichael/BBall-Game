using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreAbsorber : MonoBehaviour {

    ScoreKeeper scoreKeeper;
    public int score;

	// Use this for initialization
	void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {

        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        if (scoreKeeper)
        {
            score = scoreKeeper.score;
            DestroyObject(scoreKeeper.gameObject);
        }
    }
}
