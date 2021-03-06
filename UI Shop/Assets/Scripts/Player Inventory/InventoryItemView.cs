using UnityEngine;
using UnityEngine.UI;

public class InventoryItemView : MonoBehaviour {

    [SerializeField]
    private Text _itemName;
    [SerializeField]
    private Image _itemTexture;
    [SerializeField]
    private Text _countText;

    private ProductItem _thisItem;

    private void OnEnable() {
        ShopEvents.UpdateItemCount.AddListener(UpdateCountNumber);
        UpdateInventoryUI(_thisItem);
    }

    public void UpdateInventoryUI(ProductItem item) {
        _thisItem = item;
        _itemName.text = item.Name;
        _itemTexture.sprite = item.Texture;
        UpdateCountNumber(item);
    }

    private void UpdateCountNumber(ProductItem item) {
        _countText.text = _thisItem.Count.ToString();
    }

    private void OnDisable() {
        ShopEvents.UpdateItemCount.RemoveListener(UpdateCountNumber);
    }
}
