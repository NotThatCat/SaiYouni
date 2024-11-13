using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIInventoryCtrl : PoolObj
{
    [SerializeField] protected ItemCode _itemCode;
    public ItemCode ItemCode => _itemCode;

    [SerializeField] protected TextItemCount _itemCount;
    public TextItemCount ItemCount => _itemCount;

    [SerializeField] protected Image _itemImage;
    public Image Image => _itemImage;

    [SerializeField] protected Image _bgImage;
    public Image BGImage => _bgImage;

    public override void Init()
    {
        this.LoadComponents();
        if(this._itemCount != null)
        {
            this.UpdateItemImage();
        }
    }

    public virtual void Init(ItemCode itemCode, Image image)
    {
        this.LoadComponents();
        this._itemCode = itemCode;
        this._itemCount.LoadItemCount(this._itemCode);
        //this._itemImage = image;
        if (this._itemCount != null)
        {
            this.UpdateItemImage();
        }
    }

    protected override void LoadComponents()
    {
        this.LoadItemImage();
        this.LoadItemCount();
        this.LoadBGItemCount();
    }

    protected virtual void LoadItemImage()
    {
        if (this._itemImage != null) return;
        this._itemImage = transform.Find("Slot_Item").Find("Item").GetComponentInChildren<Image>();
    }

    protected virtual void LoadItemCount()
    {
        if (this._itemCount != null) return;
        this._itemCount = transform.Find("Slot_Item").GetComponentInChildren<TextItemCount>();
    }

    protected virtual void LoadBGItemCount()
    {
        if (this._bgImage != null) return;
        this._bgImage = transform.Find("Slot_Item").GetComponent<Image>();
    }

    public virtual void SetItemCode(ItemCode itemCode)
    {
        this._itemCode = itemCode;
    }

    protected virtual void UpdateItemImage()
    {

    }

    public override string GetName()
    {
        return "UIInventoryCtrl";
    }

    public virtual void Despawn()
    {
        this.despawn.DoDespawn();
    }
}
