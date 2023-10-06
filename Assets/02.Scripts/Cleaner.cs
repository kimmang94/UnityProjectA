using System;
using UnityEngine;

public class Cleaner : MonoBehaviour
{
    Action onClean;

    void Start()
    {
        onClean += CleaningRoomA;
        onClean += CleaningRoomB;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onClean();
        }
    }

    void CleaningRoomA()
    {
        Debug.Log("A방 청소");
    }

    void CleaningRoomB()
    {
        Debug.Log("B방 청소");
    }
}
