using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour
{

   public  int score;

    // Use this for initialization
    void Start ()
    {

        score = 0;
    }


    public void incrementScore (int scorePerHit)
    {
        score += scorePerHit;
        print("Score: " + score);
    }
}