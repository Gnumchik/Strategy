using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    private IAttackStrategy currentStrategy;

    public void PerformAtack()
    {
        currentStrategy.Attack();
    }

    public void SetStrategy(IAttackStrategy strategy)
    {
        currentStrategy = strategy;
    }
}
