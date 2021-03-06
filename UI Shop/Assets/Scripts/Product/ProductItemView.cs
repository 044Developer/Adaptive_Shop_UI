using UnityEngine;
using UnityEngine.UI;

public class ProductItemView : MonoBehaviour {

    private const char CurrencyChar = '$';

    [Header("UI Components")]
    [SerializeField]
    private Text _itemName;
    [SerializeField]
    private Text _itemPrice;
    [SerializeField]
    private Image _itemImage;
    [SerializeField]
    private Button _buyButton;
    [SerializeField]
    private PlayerCurrency _playerMoney;

    private ProductItem _item;

    private void OnEnable() {
        _buyButton.onClick.AddListener(() => ShopEvents.OnBuyButtonPressed(_item));
        _buyButton.onClick.AddListener(() => PurchaseItem(_item));
        ShopEvents.ItemPurchased += UpdateButton;
    }

    public void UpdateUI(ProductItem item) {
        _item = item;
        _itemName.text = item.Name;
        _itemPrice.text = $"{item.Price} {CurrencyChar}";
        _itemImage.sprite = item.Texture;
    }

    private void PurchaseItem(ProductItem item) {
        UpdateButton();
        _playerMoney.Purchase(item.Price);
    }

    private void UpdateButton() {
        _buyButton.interactable = _playerMoney.CheckPrice(_item.Price);
    }

    private void OnDisable() {
        ShopEvents.ItemPurchased -= UpdateButton;
    }
}
