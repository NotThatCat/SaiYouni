using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyDamageReceiver : DamageReceiver
{
    [SerializeField] protected EnemyDespawn despawn;
    [SerializeField] protected EnemyCtrl ctrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadEnemyCtrl();
        this.LoadDespawn();
    }

    protected virtual void LoadEnemyCtrl()
    {
        if (this.ctrl != null) return;
        this.ctrl = GetComponentInParent<EnemyCtrl>();
    }

    protected virtual void LoadDespawn()
    {
        if (this.despawn != null) return;
        this.despawn = transform.parent.GetComponentInChildren<EnemyDespawn>();
        Debug.Log(transform.name + ": LoadDespawn", gameObject);
    }

    protected virtual void DoDespawn()
    {
        Debug.Log(transform.name + ": DoDespawn", gameObject);
        despawn.DoDespawn();
        this.currentHP = this.maxHP;
    }

    protected override void OnDead()
    {
        Debug.Log(transform.name + ": OnDead", gameObject);
        this.ctrl.Animator.SetTrigger("isDying");
        int timerID = TimerManager.Instance.StartTimer(2f, this.DoDespawn);
        Debug.Log(transform.name + ": timerID: " + timerID, gameObject);
    }

    protected override void OnHurt()
    {
        Debug.Log(transform.name + ": OnHurt", gameObject);
        if (!this.ctrl.Animator.GetBool("isHit"))
        {
            this.ctrl.Animator.SetTrigger("isHit");
            int timerID = TimerManager.Instance.StartTimer(2f, this.ResetHurtTrigger);
        }
    }

    protected virtual void ResetHurtTrigger()
    {
        this.ctrl.Animator.ResetTrigger("isHit");
    }
}
