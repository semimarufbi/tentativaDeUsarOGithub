using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rigidbody2d;

    private void Update()
    {
        rigidbody2d.velocity = new Vector2(-GameManager.instance.Speed, rigidbody2d.velocity.y);
        if (transform.position.x < -GameManager.instance.ScreenBounds.x) 
        {
        Destroy(gameObject);
        }
    }//ABACO

}
