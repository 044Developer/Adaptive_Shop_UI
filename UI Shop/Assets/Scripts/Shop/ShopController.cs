using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour {

    [SerializeField]
    private GameObject _itemPrefab;
    [SerializeField]
    private Transform _contentTransform;
    [SerializeField]
    private List<ProductItem> _productList;

    private void Start() {
        CreateItems();
    }

    private void CreateItems() {
        for (int i = 0; i < _productList.Count; i++) {
            GameObject item = Instantiate(_itemPrefab, _contentTransform);
            item.GetComponent<ProductItemView>().UpdateUI(_productList[i]);
        }
    }
}
