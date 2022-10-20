using System;
using UnityEngine;

public class Controller : MonoBehaviour
{
    
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        if (vertical > 0.5f)
        {
            vertical = 1;
        }else if (vertical < -0.5f)
        {
            vertical = -1;
        }
        if (horizontal > 0.5f)
        {
            horizontal = 1;
        }else if (horizontal < -0.5f)
        {
            horizontal = -1;
        }
        
        GameManager.current.player.SetDirection(horizontal, vertical);
    }
}
