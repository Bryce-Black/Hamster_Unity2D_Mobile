using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreManagerNormal : MonoBehaviour 
{
    public Text scoreText;
    private float score;

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }
        if(score > 30)
        {
            SceneManager.LoadScene(3);
        }
        if (GameObject.FindGameObjectWithTag("Player").transform.position.y < -3.9f)
        {
            SceneManager.LoadScene(4);
        }
    }
}
