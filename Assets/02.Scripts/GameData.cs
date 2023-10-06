using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    private void Start()
    {
        Player1 player = FindObjectOfType<Player1>();
        player.onDeath += Saveasdfasdf;
    }

    public void Saveasdfasdf()
    {
        Debug.Log("게임 저장...");
    }
}
