using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAbove : IAttackStrategy
{
    private readonly int ABOVE_ANIM_HASH_CODE = Animator.StringToHash("second");

    public Animator Animator { get; private set; }

    public AttackAbove(Animator animator)
    {
        Animator = animator;
    }

    public void Attack()
    {
        Animator.SetTrigger(ABOVE_ANIM_HASH_CODE);
    }
}

