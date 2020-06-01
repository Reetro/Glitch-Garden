using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Health Settings")]
    [SerializeField] float health = 100f;

    [Header("VFX Settings")]
    [SerializeField] GameObject deathVFX = null;
    [SerializeField] float VFXDuration = 1f;

    public void DealDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathVFX()
    {
        if (deathVFX)
        {
            var VFX = Instantiate(deathVFX, transform.position, transform.rotation);

            Destroy(VFX, VFXDuration);
        }
    }
}
