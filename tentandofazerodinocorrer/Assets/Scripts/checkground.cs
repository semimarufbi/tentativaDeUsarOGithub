using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkground : MonoBehaviour
{
    Material texture;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        texture.mainTextureOffset += new Vector2(GameManager.instance.Speed * Time.deltaTime,0);
    }
}
