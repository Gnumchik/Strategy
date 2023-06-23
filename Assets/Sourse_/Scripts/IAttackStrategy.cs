using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttackStrategy
{
    Animator Animator { get; }

    void Attack();
}
