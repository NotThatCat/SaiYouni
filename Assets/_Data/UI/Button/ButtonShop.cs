using com.cyborgAssets.inspectorButtonPro;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonShop : ButtonAbstact
{
    [SerializeField] protected bool isActive = false;

    [ProButton]
    public virtual void AddTest()
    {
        this.button.onClick.AddListener(this.OnClick);
    }

    [SerializeField]
    protected UIShopManager uIShopManager;

    public override void OnClick()
    {
        //Debug.Log("ButtonInventory");
        //UIInventoryManager uIShopManager = GameObject.FindObjectOfType<UIInventoryManager>();
        if (!isActive)
        {
            isActive = !isActive;
            Time.timeScale = 0;
            uIShopManager.gameObject.SetActive(true);
            uIShopManager.UpdateInventory();
        }
        else
        {
            isActive = !isActive;
            Time.timeScale = 1;
            uIShopManager.gameObject.SetActive(false);
        }
    }

}
