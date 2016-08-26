using UnityEngine;
using System.Collections;

public class ScoreDetector : MonoBehaviour
{
    public int scorePerHit=1;
    ScoreKeeper scoreKeeper;

    void OnCollisionEnter(Collision collision )
    {
        scoreKeeper=FindObjectOfType<ScoreKeeper>();
        scoreKeeper.incrementScore(scorePerHit);
    }

}