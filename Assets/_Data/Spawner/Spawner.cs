using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner<T> : PMono where T : PoolObj
{
    [SerializeField] protected Transform holder;
    [SerializeField] protected int spawnCount = 0;
    [SerializeField] protected List<T> inPoolObjects = new();

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadHolder();
    }

    protected virtual void LoadHolder()
    {
        if (this.holder != null) return;
        this.holder = transform.Find("Holder");
        if (this.holder == null)
        {
            this.holder = new GameObject("Holder").transform;
            this.holder.parent = transform;
        }
        //Debug.Log(transform.name + ": LoadEffectPrefabs", gameObject);
    }

    public virtual T Spawn(T prefab, Vector3 postion, Quaternion rotation)
    {
        T newBullet = this.Spawn(prefab, postion);
        newBullet.transform.rotation = rotation;
        return newBullet;
    }

    public virtual T Spawn(T prefab, Quaternion rotation)
    {
        T newBullet = this.Spawn(prefab);
        newBullet.transform.rotation = rotation;
        return newBullet;
    }

    public virtual T Spawn(T prefab, Vector3 postion)
    {
        T newBullet = this.Spawn(prefab);
        newBullet.transform.position = postion;
        return newBullet;
    }

    public virtual T Spawn(T prefab)
    {
        T newObject = this.GetObjFromPool(prefab);
        if (newObject == null)
        {
            newObject = Instantiate(prefab);
            this.spawnCount++;
            this.UpdateName(prefab.transform, newObject.transform);
            newObject.transform.parent = this.holder;
        }

        return newObject;
    }

    protected virtual T GetObjFromPool(T prefab)
    {
        foreach (T inPoolObj in this.inPoolObjects)
        {
            if (prefab.GetName() == inPoolObj.GetName())
            {
                this.RemoveObjectFromPool(inPoolObj);
                return inPoolObj;
            }
        }

        return null;
    }

    protected virtual void RemoveObjectFromPool(T obj)
    {
        this.inPoolObjects.Remove(obj);
    }

    protected virtual void UpdateName(Transform prefab, Transform newObject)
    {
        newObject.name = prefab.name + "_" + this.spawnCount;
    }

    public virtual void Despawn(T obj)
    {
        if (obj is MonoBehaviour monoBehaviour)
        {
            monoBehaviour.gameObject.SetActive(false);
            this.AddObjectToPool(obj);
        }
    }

    protected virtual void AddObjectToPool(T obj)
    {
        this.inPoolObjects.Add(obj);
    }
}
