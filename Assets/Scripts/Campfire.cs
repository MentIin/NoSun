using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Campfire : PlayersBuilding
{
    private Animator _animator;

    private float _startTimeLeft=30f;
    private float _timeLeft=30f;
    

    private void Awake()
    {
        base.Awake();
        _timeLeft = _startTimeLeft;
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _timeLeft += 5f;
        }
        base.Update();
        _timeLeft -= Time.deltaTime;
        if (_timeLeft <= 0)
        {
            Die();
        }
        
        SetAnimations();
    }

    private void SetAnimations()
    {
        if (_timeLeft <= 10)
        {
            _animator.SetInteger("intensity", 0);
        }else if (_timeLeft <= 20)
        {
            _animator.SetInteger("intensity", 1);
        }
        else
        {
            _animator.SetInteger("intensity", 2);
        }
    }

    private void Die()
    {
        Destroy(this.gameObject);
    }
    
}
