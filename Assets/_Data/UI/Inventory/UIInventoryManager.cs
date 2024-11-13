using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventoryManager : PMono
{
    [SerializeField] protected UIInventorySpawner spawner;
    [SerializeField] protected UIInventoryCtrl uiInvetory;
    [SerializeField] protected Transform spawnPoint;
    [SerializeField] protected float timer = 0;
    [SerializeField] protected float delay = 1f;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDespawn();
    }

    protected virtual void LoadDespawn()
    {
        if (this.spawner != null) return;
        this.spawner = transform.GetComponent<UIInventorySpawner>();
        //Debug.Log(transform.name + ": LoadSpawner", gameObject);
    }

    public virtual void UpdateInventory()
    {
        this.ClearInventory();
        List<InventoryCtrl> inventoryCtrls = InventoriesManager.Instance.GetInventories();
        foreach (InventoryCtrl inventoryCtrl in inventoryCtrls)
        {
            if (inventoryCtrl != null)
            {
                foreach(ItemInventory itemInventory in inventoryCtrl.Items)
                {
                    this.Spawn(itemInventory);
                }
            }
        }
    }
    
    protected virtual void Spawn(ItemInventory itemInventory)
    {
        UIInventoryCtrl newUIInventoryCtrl = spawner.Spawn(this.uiInvetory, spawnPoint.position);
        newUIInventoryCtrl.Init(itemInventory.ItemProfile.itemCode, null);
        newUIInventoryCtrl.gameObject.SetActive(true);
    }

    public virtual void OnDisable()
    {
        this.ClearInventory();
    }

    protected virtual void ClearInventory()
    {
        UIInventoryCtrl[] uIInventoryCtrls = transform.GetComponentsInChildren<UIInventoryCtrl>();
        foreach (UIInventoryCtrl uIInventoryCtrl in uIInventoryCtrls)
        {
            uIInventoryCtrl.Despawn();
        }
    }
}
