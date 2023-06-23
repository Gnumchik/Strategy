using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPerformer : MonoBehaviour
{
    private PlayerController _playerController;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            _playerController.PerformAtack();
    }

    public void Construct(PlayerController playerController)
    {
        _playerController = playerController;
    }
}
