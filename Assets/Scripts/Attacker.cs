using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 5f)] float currentSpeed = 1f;

    GameObject currentTarget = null;

    void Update()
    {
        transform.Translate(UnityEngine.Vector2.left * currentSpeed * Time.deltaTime);
        UpdateAnimationState();
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("IsAttacking", true);
        currentTarget = target;
    }
    public void StrikeTarget(float damage)
    {
        if (!currentTarget) { return; }

        Health health = currentTarget.GetComponent<Health>();

        if (health)
        {
            health.DealDamage(damage);
        }
    }

    private void UpdateAnimationState()
    {
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("IsAttacking", false);
        }
    }

}
