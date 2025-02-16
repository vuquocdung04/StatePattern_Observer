using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UImanager_1 : MonoBehaviour
{
    [SerializeField] protected TMP_Text text;
    int score;
    private void Start()
    {
        ObserverManager_1.AddObserver("OnUpdateUI", OnUpdateUI);
    }
    private void OnDestroy()
    {
        ObserverManager_1.RemoveListener("OnUpdateUI", OnUpdateUI);
    }

    void OnUpdateUI()
    {
        text.text = "Score: " + score++.ToString();
    }
}
