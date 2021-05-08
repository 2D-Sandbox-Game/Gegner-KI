using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    public float currentHealth = 5; //Leben und Methode zum Schaden erhalten
    // Start is called before the first frame update
    public GameObject objectToDestroy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ApplyDamage(float damage)
    {
        if (currentHealth > 0)
        {
            currentHealth -= damage;

            if (currentHealth < 0)
            {
                currentHealth = 0;
            }
            if (currentHealth == 0)
            {
                Destroy(objectToDestroy);
            }
        }
    }
}
