using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalWinLose : MonoBehaviour
{
    private bool gameEnded;
    public void LoseLevel()
    {
        if(!gameEnded)
        {
            gameEnded = true;
        }
    }
}
