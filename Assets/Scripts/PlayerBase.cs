using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    [SerializeField] int healthToRemove = 1;

    PlayerHealthDisplay healthDisplay = null;

    private void Start()
    {
        healthDisplay = FindObjectOfType<PlayerHealthDisplay>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject currentObject = collision.gameObject;

        if (currentObject.GetComponent<Attacker>())
        {
            healthDisplay.RemoveHealth(healthToRemove);

            Destroy(collision.gameObject);
        }
    }
}
