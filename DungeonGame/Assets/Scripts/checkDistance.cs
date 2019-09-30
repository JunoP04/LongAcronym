using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkDistance : MonoBehaviour
{
    private int distanceThreshold;

    //public GameObject trap;
    public Transform enemy;
    public Transform other;

    // Update is called once per frame
    void Update()
    {
  

        if (other)
        {
            //transform en = enemy.position;
            float dist = Vector3.Distance(other.position, enemy.position);
            Debug.Log("distance is " + dist);

            while (dist < 2000)
            { 
            Debug.Log("enemy is in range");
            
                if (dist == 2000)
                {
                    Destroy(enemy);
                    Debug.Log("enemy destroyed");
                    break;
                }
      
            }
        }
        //if (dist <= 10)
        //{
        //    Destroy(enemy);
        //    Debug.Log("enemy destroyed");
        //}
    }
}
