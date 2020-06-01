using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float damage = 50f;
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var healthcomp = collision.GetComponent<Health>();
        var attacker = collision.GetComponent<Attacker>();

        if (healthcomp && attacker)
        {
            healthcomp.DealDamage(damage);
            Destroy(gameObject);
        }
    }
}
