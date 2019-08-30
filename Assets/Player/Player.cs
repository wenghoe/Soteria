using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamageable
{
    [SerializeField] float maxHealthPoints = 100f;
    [SerializeField] float maxSkill1Charge = 100f;
    [SerializeField] float maxFearPoints = 100f;

    float currentHealthPoints = 100f;
    float currentSkill1Charge = 40f;
    float currentFearPoints = 40f;

    void Start()
    {
        StartCoroutine(RegenerateSkillCharge());
    }

    void Update()
    {
        if (Input.GetButtonDown("Skill1") && (currentSkill1Charge == maxSkill1Charge))
        {
            Debug.Log("Skill 1 restored 20HP.");
            RecoverHealth(20f);
            currentSkill1Charge = 0f;
        }
    }

    public float healthAsPercentage
    {
        get
        {
            return currentHealthPoints / (float)maxHealthPoints;
        }
    }

    public float skill1AsPercentage
    {
        get
        {
            return currentSkill1Charge / (float)maxSkill1Charge;
        }
    }

    public float fearAsPercentage
    {
        get
        {
            return currentFearPoints / (float)maxFearPoints;
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealthPoints = Mathf.Clamp(currentHealthPoints - damage, 0f, maxHealthPoints);
        //if (currentHealthPoints <= 0) { Destroy(gameObject); }
    }

    public void RecoverHealth(float health)
    {
        currentHealthPoints = Mathf.Clamp(currentHealthPoints + health, 0f, maxHealthPoints);
    }

    public void IncreaseFear(float damage)
    {
        currentFearPoints = Mathf.Clamp(currentFearPoints + damage, 0f, maxFearPoints);
    }

    IEnumerator RegenerateSkillCharge()
    {
        while (true)
        {
            currentSkill1Charge = Mathf.Clamp(currentSkill1Charge + 10f, 0f, maxSkill1Charge);
            yield return new WaitForSeconds(1);
        }
    }
}
