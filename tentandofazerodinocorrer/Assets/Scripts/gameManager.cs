using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    float speed = 4;
    int score;
    Vector2 screenBounds;

   
    public Vector2 ScreenBounds { get => screenBounds;  }
    public float Speed { get => speed; set => speed = value; }
    public int Score { get => score; set => score = value; }
    #region sigleton
    private void Awake()
    {
        instance = this;
        screenBounds = new Vector3(1, 0, 0) + Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
