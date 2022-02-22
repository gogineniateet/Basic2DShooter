using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        MovementOfPlayer(playerSpeed);
    }

    private void MovementOfPlayer(float speed)
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x >= -10.0f)
            transform.Translate(-playerSpeed,0,0);
        else if(Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x <= 10.0f)
            transform.Translate(playerSpeed, 0, 0);
        else if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y <= 3.5f)
            transform.Translate(0, playerSpeed, 0);
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y >= -3.5f)
            transform.Translate(0, -playerSpeed, 0);
    }   
}
