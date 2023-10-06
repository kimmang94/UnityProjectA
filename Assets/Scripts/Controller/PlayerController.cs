using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private JoyStick virtualJoysticlJoyStick;
    private float moveSpeed = 10f;
    
    void Start()
    {

    }


    void Update()
    {
        PlayerVirtualPadMove();
    }

    private void PlayerVirtualPadMove()
    {
        float x = virtualJoysticlJoyStick.Horizontal;	// 좌/우 이동
        float z = virtualJoysticlJoyStick.Vertical;		// 위/아래 이동

        if ( x != 0 || z != 0 )
        {
            transform.position += new Vector3(x, 0, z) * moveSpeed * Time.deltaTime;
        }
    }
}
