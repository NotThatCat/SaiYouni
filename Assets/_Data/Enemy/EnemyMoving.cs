using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoving : EnemyAbstract
{
    [SerializeField] protected PathMoving _path;
    [SerializeField] protected int _currentPointIndex = 0;
    [SerializeField] protected Point _currentPoint;
    [SerializeField] protected float _pointDistance = Mathf.Infinity;
    [SerializeField] protected float _pointDistanceLimit = 1f;
    [SerializeField] protected bool _isFinish = false;
    [SerializeField] protected bool _isMoving = false;

    void FixedUpdate()
    {
        this.Moving();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPathMoving();
    }

    protected virtual void LoadPathMoving()
    {
        if (_path != null) return;
        _path = GameObject.Find("PathMoving_0").GetComponent<PathMoving>();
    }

    protected virtual void Moving()
    {
        this.LoadMovingStatus();
        if (_isFinish)
        {
            this.ctrl.Agent.isStopped = true;
            return;
        }

        this.GetNextPoint();
        this.ctrl.Agent.SetDestination(_currentPoint.transform.position);
    }

    protected virtual void GetNextPoint()
    {
        _currentPoint = _path.GetPoint(_currentPointIndex);
        _pointDistance = Vector3.Distance(_currentPoint.transform.position, transform.position);
        if (_pointDistance < _pointDistanceLimit) _currentPointIndex++;
        if (_currentPointIndex > _path.Points.Count - 1) _isFinish = true;
    }

    protected virtual void LoadMovingStatus()
    {
        _isMoving = !this.ctrl.Agent.isStopped;
        this.ctrl.Animator.SetBool("isMoving", _isMoving);
    }
}
