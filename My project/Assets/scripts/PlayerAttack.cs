using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] fireballs;

    private Animator anim;
    private PlayerMovement playerMovement;
    private float cooldownTimer = Mathf.Infinity;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && cooldownTimer > attackCooldown && playerMovement.canAttack())
            attack();

        cooldownTimer += Time.deltaTime;
    }

    private void attack()
    {
        anim.SetTrigger("attack");
        cooldownTimer = 0;
        //pool fireball

        fireballs[0].transform.position = firePoint.position;
        fireballs[0].GetComponent<Projectile>().setDirection(Mathf.Sign(transform.localScale.x));
    }
}
