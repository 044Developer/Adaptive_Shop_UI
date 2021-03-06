using UnityEngine;
using UnityEngine.UI;

public class PlayerCurrancyController : MonoBehaviour {

    private const char CurrencyChar = '$';
    [SerializeField]
    private Text _moneyText;
    [SerializeField]
    private PlayerCurrency _currentMoneyCount;

    private void OnEnable() {
        SubscribeOnEvents();
    }

    private void SubscribeOnEvents() {
        ShopEvents.ItemPurchased += UpdateUI;
    }

    private void Start() {
        UpdateUI();
    }

    private void UpdateUI() {
        _moneyText.text = $"{_currentMoneyCount.GetBallance()} {CurrencyChar}";
    }

    private void OnDisable() {
        UnSubscribeOnEvents();
    }

    private void UnSubscribeOnEvents() {
        ShopEvents.ItemPurchased -= UpdateUI;
    }
}
