using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreMangerHARD : MonoBehaviour
{
    public Text scoreText;

    public int HardCoreScore = 0;
    public TouchJumpHardCore hardy;


    public void Update()
    {
        if (hardy.HardCoreScore != 0)
        {
            scoreText.text = ((int)hardy.HardCoreScore).ToString();
        }
        if (hardy.HardCoreScore > 30)
        {
            SceneManager.LoadScene(6);
        }
        if (GameObject.FindGameObjectWithTag("Player").transform.position.y < -3.8f)
        {
            SceneManager.LoadScene(7);
        }
    }
}
