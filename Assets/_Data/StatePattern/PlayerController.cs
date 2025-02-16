using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] protected StateBase currentState;
    int stateNumber = 0;
    private void Start()
    {
        currentState = this.gameObject.AddComponent<StateColor>();
        if(currentState != null)
        {
            currentState._Start();
        }
    }

    private void Update()
    {
        if(currentState != null)
        {
            currentState._Update();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(stateNumber == 0)
            {
                stateNumber = 1;
                Destroy(currentState);
                currentState = this.gameObject.AddComponent<StateScale>();
                currentState._Start();
            }
            else
            {
                stateNumber = 0;
                Destroy(currentState);
                currentState = this.gameObject.AddComponent<StateColor>();
                currentState._Start();
            }
        }
    }
}
