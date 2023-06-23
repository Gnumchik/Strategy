using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongAttack : IAttackStrategy
{
    private readonly int STRONG_ANIM_HASH_CODE = Animator.StringToHash("first");

    public Animator Animator { get; private set; }

    public StrongAttack(Animator animator)
    {
        Animator = animator;
    }

    public void Attack()
    {
        Animator.SetTrigger(STRONG_ANIM_HASH_CODE);
    }
}
