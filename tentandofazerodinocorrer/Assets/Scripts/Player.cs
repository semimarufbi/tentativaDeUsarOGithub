using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    bool onGround, doubleJump, jumping;
    float lowJumpingMultiplier = 1.5f, fallMultiplier = 2.5f;
    [SerializeField]
    Rigidbody2D rigidBody2D;
    [SerializeField]
    LayerMask checkGround;
    // Start is called before the first frame update
   void jump()
    {
        if (onGround = true)
        {
            rigidBody2D.velocity =new Vector2(0,8);
        }
        else if(doubleJump=true)
        {
            rigidBody2D.velocity=new Vector2(0,8);
            doubleJump = false;
        }
    }
    void checkground()
    {
        onGround = Physics2D.OverlapCircle(transform.position,0.2f,checkGround);
        if (onGround == true)
        {
            doubleJump = true;
        }
    }
    void updategravity()
    {
        if (rigidBody2D.velocity.y>0 && jumping==false)
        { 
            rigidBody2D.velocity = Physics2D.gravity*Time.deltaTime;
        }
        else if (rigidBody2D.velocity.y < 0)
        {
            rigidBody2D.velocity = Physics2D.gravity * fallMultiplier * Time.deltaTime;
        }
    }
   void Update()
    {
        checkground();
         updategravity();
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            jump();
            jumping = true;
            if(Input.GetKeyUp(KeyCode.Escape) == true)
            {
                jumping = false;
            }
        }
       
    }
    void gameover()
    {
        if (GameManager.instance.Score>PlayerPrefs.GetInt("Record"))
        {
            PlayerPrefs.SetInt("Record",GameManager.instance.Score);
            Time.timeScale = 0;
            WindowManager.instance.GameOverWindown.SetActive(true);
           WindowManager.instance.FinalScoreText.text = "Score" + GameManager.instance.Score;
            WindowManager.instance.RecordText.text = "Record" + PlayerPrefs.GetInt("Record");
            
                
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("obstacle")) 
        {
            gameover();
        }
        else if (collision.gameObject.CompareTag("Point"))
        {
            GameManager.instance.Score = 1;
            WindowManager.instance.ScoreText.text = GameManager.instance.Score + "score;";
        }
    }
}
