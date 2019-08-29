using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FearSensor : MonoBehaviour
{
    Player playerComponent;
    void Awake()
    {
        playerComponent = GetComponentInParent<Player>();
    }
    

    void OnTriggerEnter(Collider collider)
    {
        bool damageableComponent = collider.gameObject.tag == "Enemy";
        if (damageableComponent)
        {
            Debug.Log("Enemy in range");
            playerComponent.IncreaseFear(10f);            
        }
        
    }
}
