using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool onGround, doubleJump, jumping;
    float lowJumpingMultiplier = 1.5f, fallMultiplier = 2.5f;
    [SerializeField]
    Rigidbody2D Rigidbody2D;
    [SerializeField]
    LayerMask layerMask;
    // Start is called before the first frame update
   void jump()
    {
        if (onGround = true)
        {
            Rigidbody2D.velocity =new Vector2(0,8);
        }
        else if(doubleJump=true)
        {
            Rigidbody2D.velocity=new Vector2(0,8);
            doubleJump = false;
        }
    }
    void updategravity(Physics2D overlapcircle)
    {

    }
}
