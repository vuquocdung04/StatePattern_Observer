using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestObserver_2 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ObserverManager_2<int>.Notify(1);
            ObserverManager_2<float>.Notify(0.7f);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            ObserverManager_NoParam.Notify();
        }
    }
}
