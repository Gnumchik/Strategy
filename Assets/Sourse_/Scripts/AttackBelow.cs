using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBelow : IAttackStrategy
{
    private readonly int BELOW_ANIM_HASH_CODE = Animator.StringToHash("tree");

    public Animator Animator { get; private set; }

    public AttackBelow(Animator animator)
    {
        Animator = animator;
    }

    public void Attack()
    {
        Animator.SetTrigger(BELOW_ANIM_HASH_CODE);
    }
}