using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FearSensor : MonoBehaviour
{
    Player playerComponent;
    private float timer = 0;
    float interval = 3f;

    void Awake()
    {
        playerComponent = GetComponentInParent<Player>();
    }
    
    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
            if (timer > interval)
            {
                playerComponent.IncreaseFear(3f);
                timer = 0f;
            }
            
        }
        
    }
}
