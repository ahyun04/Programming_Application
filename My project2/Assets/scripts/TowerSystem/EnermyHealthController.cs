using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyHealthController : MonoBehaviour
{
    public int totalHealth;

    public int moneyOnDeayh = 50;

    public void TakeDamage(int damageAmount)
    {
        totalHealth -= damageAmount;

        if(totalHealth <= 0)
        {
            totalHealth = 0;
            Destroy(gameObject);
        }
    }
}
