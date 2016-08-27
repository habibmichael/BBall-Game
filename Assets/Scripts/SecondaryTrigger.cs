using UnityEngine;
using System.Collections;

public class SecondaryTrigger : MonoBehaviour {

    Collider expectedCollider;
    ScoreKeeper scoreKeeper;



  public  void expectCollider(Collider collider )
    {
        expectedCollider = collider;
    }

    void OnTriggerEnter ( Collider collider )
    {
        if (expectedCollider == collider)
        {
            scoreKeeper = FindObjectOfType<ScoreKeeper>();
            scoreKeeper.incrementScore(1);
        }
    }
}

