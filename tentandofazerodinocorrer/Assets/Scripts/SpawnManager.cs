using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    float cooldown := 2;
    float clock;
    [SerializeField]
    GameObject object;

   


      private void Update()
    {
      
        if (clock <= 0)
        {
            Vector3 spawnPosition = new Vector3(GameManager.instance.ScreenBounds.x, -4, 0);
            Instantiate(obstacle, spawnPosition, Quaternion.identity);

            if (GameManager.instance.Speed < 10)
            {
               
                GameManager.instance.Speed += 0.1f;
            }
            
            if (cooldown > 1)
            {
                
                cooldown -= 0.1f;
            }
    
            clock = cooldown;
        }
        else
        {
            clock -= Time.deltaTime;
        }
    }
}
}
