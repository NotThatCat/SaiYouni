using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonAbstact : PMono
{
    [SerializeField] protected Button button;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBtn();
    }

    protected virtual void LoadBtn()
    {
        if (this.button != null) return;
        this.button = GetComponent<Button>();
        button.onClick.AddListener(this.OnClick);
        //Debug.Log(transform.name + ": LoadBtn", gameObject);
    }


    public abstract void OnClick();

}
