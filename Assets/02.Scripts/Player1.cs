using System;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public event Action onDeath;

    void Start()
    {
        Die();
    }

    public void Die()
    {
        // ªÁ∏¡√≥∏Æ..
        onDeath();
    }
}
