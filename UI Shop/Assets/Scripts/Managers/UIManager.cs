using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    [Header("Buttons")]
    [SerializeField]
    private Button _shopButton;
    [SerializeField]
    private Button _inventoryButton;
    [SerializeField]
    private Button _closeShopButton;
    [SerializeField]
    private Button _closeInventoryButton;

    [Header("Panels")]
    [SerializeField]
    private GameObject _shopPanel;
    [SerializeField]
    private GameObject _inventoryPanel;
    [SerializeField]
    private GameObject _bottomPanel;

    private void Start() {
        InitializeButtons();
    }

    private void InitializeButtons() {
        _shopButton.onClick.AddListener(OpenShopPanel);
        _inventoryButton.onClick.AddListener(OpenInventoryPanel);
        _closeShopButton.onClick.AddListener(CloseShopPanel);
        _closeInventoryButton.onClick.AddListener(CloseInventoryPanel);
    }

    private void OpenShopPanel() {
        _shopPanel.SetActive(true);
        _bottomPanel.SetActive(false);
    }

    private void CloseShopPanel() {
        _shopPanel.SetActive(false);
        _bottomPanel.SetActive(true);
    }

    private void OpenInventoryPanel() {
        _inventoryPanel.SetActive(true);
        _bottomPanel.SetActive(false);
    }

    private void CloseInventoryPanel() {
        _inventoryPanel.SetActive(false);
        _bottomPanel.SetActive(true);
    }
}

