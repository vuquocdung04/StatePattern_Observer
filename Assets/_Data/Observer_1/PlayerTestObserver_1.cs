using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestObserver_1 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ObserverManager_1.Notify("OnUpdateUI");
        }
    }
}
