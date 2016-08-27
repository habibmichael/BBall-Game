using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

   public  float timeTillNextLevel = 10.0f;

    public void loadNextScene ()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }

    public void loadPreviousScene ()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene - 1);
    }

    void Update ()
    {
     //   if (timeTillNextLevel > 0)
     //   {
            timeTillNextLevel -= Time.deltaTime;

     //       if (timeTillNextLevel < 0)
      //      {
          //      loadNextScene();
        //    }
      //  }
    }


}
