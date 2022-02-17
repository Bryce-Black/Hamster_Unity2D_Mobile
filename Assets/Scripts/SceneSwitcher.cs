using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void NormalMode()
    {
        SceneManager.LoadScene(1);
    }

    public void EndlessMode()
    {
        SceneManager.LoadScene(2);
    }

    public void RollCredits()
    {
        SceneManager.LoadScene(3);
    }

    public void HardCoreMode()
    {
        SceneManager.LoadScene(5);
    }
    public void HardCoreModeWin()
    {
        SceneManager.LoadScene(6);
    }
    public void HardCoreModeDeath()
    {
        SceneManager.LoadScene(7);
    }
    public void ActuallyFun()
    {
        SceneManager.LoadScene(8);
    }
    public void ActuallyFunDeath()
    {
        SceneManager.LoadScene(9);
    }
}
