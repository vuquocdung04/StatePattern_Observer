using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UImanager_2 : MonoBehaviour
{
    [SerializeField] protected TMP_Text textScore;
    [SerializeField] protected TMP_Text textCoinFloat;
    int score;
    float coin;
    private void Start()
    {
        ObserverManager_2<int>.AddObserver(OnUpdateScore);
        ObserverManager_2<float>.AddObserver(OnUpdateCoin);

        // no param

        ObserverManager_NoParam.AddObserver(OnUpdateScoreNoParam);
        ObserverManager_NoParam.AddObserver(OnUpdateCoinNoParam);
    }
    private void OnDestroy()
    {
        ObserverManager_2<int>.RemoveObserver(OnUpdateScore);
        ObserverManager_2<float>.RemoveObserver(OnUpdateCoin);

        // no param
        ObserverManager_NoParam.RemoveObserver(OnUpdateScoreNoParam);
        ObserverManager_NoParam.RemoveObserver(OnUpdateCoinNoParam);
    }

    void OnUpdateScore(int value)
    {
        score += value;
        textScore.text = "Score: " + score.ToString();
    }
    void OnUpdateCoin(float value)
    {
        coin += value;
        textCoinFloat.text = "Coin: " + coin.ToString();
    }

    void OnUpdateScoreNoParam()
    {
        score++;
        textScore.text = "ScoreNoParam: " + score.ToString();
    }
    void OnUpdateCoinNoParam()
    {
        coin+= 0.8f;
        textCoinFloat.text = "ScoreNoParam: " + coin.ToString();
    }
}
