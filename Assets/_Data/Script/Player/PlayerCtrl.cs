using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerCtrl : PMono
{

    [SerializeField] protected Animator _animator;
    public Animator Animator => _animator;

    protected override void LoadComponents()
    {
        this.LoadAnimator();
    }

    protected virtual void LoadAnimator()
    {
        if (this._animator != null) return;
        this._animator = transform.Find("Model").GetComponent<Animator>();
    }

}
