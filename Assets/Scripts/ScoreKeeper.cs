using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour
{

   public  int score=0;

    // Use this for initialization
    void Start ()
    {

        DontDestroyOnLoad(gameObject);
    }


    public void incrementScore (int scorePerHit)
    {
        score += scorePerHit;
        print("Score: " + score);
    }
}