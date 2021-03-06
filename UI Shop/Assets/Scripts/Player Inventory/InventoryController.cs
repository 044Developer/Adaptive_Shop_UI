using UnityEngine;

public class InventoryController : MonoBehaviour {

    [SerializeField]
    private GameObject _inventoryPrefab;
    [SerializeField]
    private Transform _contentTransform;
    [SerializeField]
    private InventoryData _playerInventory;

    private void OnEnable() {
        ShopEvents.BuyButtonPressed.AddListener(CheckInventory);
    }

    private void CheckInventory(ProductItem item) {
        if (item.CheckNewItem()) {
            ShopEvents.OnUpdateItemCount(item);
        }
        else {
            CreateNewSlot(item);
        }
    }

    public void CreateNewSlot(ProductItem item) {
        GameObject newItemSlot = Instantiate(_inventoryPrefab, _contentTransform);
        newItemSlot.GetComponent<InventoryItemView>().UpdateInventoryUI(item);
    }

    private void OnDisable() {
        ShopEvents.BuyButtonPressed.RemoveListener(CheckInventory);
    }
}
