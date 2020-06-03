using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    [SerializeField] float jumpingSpeed = 2f;

    Attacker attacker;
    Animator animator;
    Rigidbody2D physicsBody;

    private void Start()
    {
        attacker = GetComponent<Attacker>();
        animator = GetComponent<Animator>();
        physicsBody = GetComponent<Rigidbody2D>();
    }

    public void FinishJumpingOver()
    {
        physicsBody.simulated = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Gravestone>())
        {
            if (AttemptToJumpOver(collision.gameObject))
            {
                return;
            }
        }

        if (collision.GetComponent<Defender>())
        {
            attacker.Attack(collision.gameObject);
        }
    }

    private bool AttemptToJumpOver(GameObject target)
    {
        Vector2 positionBehind = new Vector2(
            Mathf.Clamp(target.transform.position.x - 1, 0, target.transform.position.x),
            target.transform.position.y
        );

        foreach (var defender in FindObjectsOfType<Defender>())
        {
            bool isOnSameLine = Mathf.Abs(positionBehind.y - defender.transform.position.y) <= Mathf.Epsilon;
            bool isBehind = Mathf.Abs(positionBehind.x - defender.transform.position.x) <= Mathf.Epsilon;

            if (isOnSameLine && isBehind)
            {
                return false;
            }
        }

        animator.SetTrigger("JumpTrigger");
        attacker.SetMovementSpeed(jumpingSpeed);
        physicsBody.simulated = false;

        return true;
    }
}
