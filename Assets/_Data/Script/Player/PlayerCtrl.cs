using Invector.vCharacterController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerCtrl : PMono
{

    [SerializeField] protected Animator _animator;
    public Animator Animator => _animator;

    [SerializeField] protected Invector.vCharacterController.vThirdPersonController _controller;
    public vThirdPersonController Controller => _controller;
    [SerializeField] protected Invector.vCharacterController.vThirdPersonInput _input;
    public vThirdPersonInput Input => _input;

    protected override void LoadComponents()
    {
        this.LoadAnimator();
        this.LoadController();
        this.LoadInput();
    }

    protected virtual void LoadAnimator()
    {
        if (this._animator != null) return;
        this._animator = transform.Find("Model").GetComponent<Animator>();
    }

    protected virtual void LoadController()
    {
        if (this._controller != null) return;
        this._controller = transform.Find("Model").GetComponent<vThirdPersonController>();
    }

    protected virtual void LoadInput()
    {
        if (this._input != null) return;
        this._input = transform.Find("Model").GetComponent<vThirdPersonInput>();
    }

    public virtual void DisableInput()
    {
        
    }
}
