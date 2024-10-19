using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCtrl : PMono
{

    [SerializeField] protected NavMeshAgent _agent;
    public NavMeshAgent Agent => _agent;

    [SerializeField] protected Animator _animator;
    public Animator Animator => _animator;

    protected override void LoadComponents()
    {
        this.LoadAgent();
        this.LoadAnimator();
    }

    protected virtual void LoadAgent()
    {
        if (this._agent != null) return;
        this._agent = GetComponent<NavMeshAgent>();
    }

    protected virtual void LoadAnimator()
    {
        if (this._animator != null) return;
        this._animator = transform.Find("Model").GetComponent<Animator>();
    }
}
