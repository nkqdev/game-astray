using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearTrap : Trap
{
    private Animator anim;

    private bool IsWorking;
    [SerializeField] private float cooldown;
    private float cooldownTimer;

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsWorking)
        {
            base.OnTriggerEnter2D(collision);
        }

    }

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer < 0)
        {
            IsWorking = !IsWorking;
            cooldownTimer = cooldown;
        }
        anim.SetBool("IsWorking", IsWorking);
    }
}
