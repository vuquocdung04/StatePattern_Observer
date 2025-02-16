using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    [SerializeField] protected TMP_Text text;

    private void Start()
    {
        ObserverManager.Instance.AddListener("ScoreChange", SetScoreText);
    }

    public void SetScoreText(object score)
    {
        this.text.text = "Score: " + score.ToString();
    }
}
