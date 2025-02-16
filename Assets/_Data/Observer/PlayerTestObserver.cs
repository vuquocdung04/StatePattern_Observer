using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestObserver : MonoBehaviour
{
    int score;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score++;
            ObserverManager.Instance.Notify("ScoreChange",score);
        }
    }
}
