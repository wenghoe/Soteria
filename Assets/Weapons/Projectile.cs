using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed;

    float damageCaused;

    void Start()
    {
        FloatingTextController.Initialize();
    }

    public void SetDamage(float damage)
    {
        damageCaused = damage;
    }

    void OnCollisionEnter(Collision collision)
    {
        Component damageableComponent = collision.gameObject.GetComponent(typeof(IDamageable));
        if (damageableComponent)
        {
            (damageableComponent as IDamageable).TakeDamage(damageCaused);
            FloatingTextController.CreateFloatingText(damageCaused.ToString(), transform);
        }
        Destroy(gameObject, 0.01f);
    }
}
