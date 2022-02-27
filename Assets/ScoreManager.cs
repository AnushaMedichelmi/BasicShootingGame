using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
  public int score;
    public void ScoreCalculator(int scoreValue)
    {
        score = score+scoreValue;
        Debug.Log("score"+score);
        if(score==100)
        {
            Debug.Log("you won the game");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            score = 0;
            
        }
    }
}
