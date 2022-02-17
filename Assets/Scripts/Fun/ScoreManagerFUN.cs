using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreManagerFUN : MonoBehaviour
{
    public Text scoreText;
    public Text highScore;

    public int FunScore = 0;
    public int HighFunScore;
    public TouchJumpFun Fun;

    private void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    public void Update()
    {
        if (Fun.FunScore != 0)
        {
            scoreText.text = ((int)Fun.FunScore).ToString();         
        }


        if (GameObject.FindGameObjectWithTag("Player").transform.position.y < -3.8f)
        {
            if (Fun.FunScore > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", Fun.FunScore);
            }

            SceneManager.LoadScene(9);
        }
    }
}
