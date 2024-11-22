using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShopManager : PMono
{
    [SerializeField] protected UIShopSpawner spawner;
    [SerializeField] protected UIShopCtrl uiInvetory;
    [SerializeField] protected Transform spawnPoint;
    [SerializeField] protected List<UIShopCtrl> uIShopCtrls;
    [SerializeField] protected float timer = 0;
    [SerializeField] protected float delay = 1f;


    protected override void LoadComponents()
    {
        this.LoadShopCtrl();
        this.Spawner();
    }

    protected virtual void LoadShopCtrl()
    {
        if (this.uiInvetory != null) return;
        this.uiInvetory = transform.GetComponentInChildren<UIShopCtrl>();
        //Debug.Log(transform.name + ": LoadSpawner", gameObject);
    }

    protected virtual void Spawner()
    {
        if (this.spawner != null) return;
        this.spawner = transform.GetComponent<UIShopSpawner>();
        //Debug.Log(transform.name + ": LoadSpawner", gameObject);
    }

    public virtual void UpdateInventory()
    {
        this.ClearInventory();
        InventoryCtrl inventoryCtrl = ShopManager.Instance.GetInventory();
        if (inventoryCtrl != null)
        {
            foreach (ItemInventory itemInventory in inventoryCtrl.Items)
            {
                this.Spawn(itemInventory);
            }
        }
    }

    protected virtual void Spawn(ItemInventory itemInventory)
    {
        UIShopCtrl newUIShopCtrl = spawner.Spawn(this.uiInvetory, spawnPoint.position);
        newUIShopCtrl.Init(itemInventory);
        newUIShopCtrl.gameObject.SetActive(true);
    }

    public virtual void OnDisable()
    {
        this.ClearInventory();
    }

    protected virtual void ClearInventory()
    {
        UIShopCtrl[] uIShopCtrls = transform.GetComponentsInChildren<UIShopCtrl>();
        foreach (UIShopCtrl uIShopCtrl in uIShopCtrls)
        {
            uIShopCtrl.DoDespawn();
        }
    }
}
