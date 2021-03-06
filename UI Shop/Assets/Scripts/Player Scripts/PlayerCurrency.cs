using UnityEngine;

[CreateAssetMenu(menuName = "Player/Currency")]
public class PlayerCurrency : ScriptableObject {

    [SerializeField]
    private float _playerMoney;

    private float _currentMoney;

    private void OnEnable() {
        _currentMoney = _playerMoney;
    }

    public float GetBallance() {
        return _currentMoney;
    }

    public bool CheckPrice(float price) {
        if (price <= _currentMoney) {
            return true;
        }
        else {
            return false;
        }
    }

    public void Purchase(float price) {
        if (price <= _currentMoney) {
            _currentMoney -= price;
            ShopEvents.OnItemPurchased();
        }
    }
}
