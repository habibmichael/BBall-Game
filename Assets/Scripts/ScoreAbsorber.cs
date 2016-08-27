using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreAbsorber : MonoBehaviour {

    ScoreKeeper scoreKeeper;
    public int score;

	// Use this for initialization
	void Start () {

        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        if (scoreKeeper)
        {
            score = scoreKeeper.score;
            DestroyObject(scoreKeeper.gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
