using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float damage = 100f;
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var healthcomp = collision.GetComponent<Health>();

        if (healthcomp)
        {
            healthcomp.DealDamage(damage);
        }
    }
}
