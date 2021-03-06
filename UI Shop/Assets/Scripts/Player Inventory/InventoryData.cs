using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/Inventory")]
public class InventoryData : ScriptableObject {

    private List<ProductItem> _inventoryItems = new List<ProductItem>();
    public List<ProductItem> InventoryItems { get => _inventoryItems; }
}
