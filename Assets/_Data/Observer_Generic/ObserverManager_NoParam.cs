using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverManager_NoParam : MonoBehaviour
{
    static List<Action> listeners_1 = new List<Action>();
    #region Khong tham tri
    public static void AddObserver(Action callback)
    {
        if (!listeners_1.Contains(callback))
            listeners_1.Add(callback);
    }
    public static void RemoveObserver(Action callback)
    {
        if (!listeners_1.Contains(callback))
            return;
        listeners_1.Remove(callback);
    }

    public static void Notify()
    {
        if (listeners_1.Count < 1) return;

        foreach (Action action in listeners_1)
        {
            action?.Invoke();
        }
    }
    #endregion
}
