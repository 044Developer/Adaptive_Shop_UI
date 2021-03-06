using UnityEngine.Events;

public static class ShopEvents {

    public delegate void ShopEvent();
    public static UnityEvent<ProductItem> BuyButtonPressed = new UnityEvent<ProductItem>();
    public static event ShopEvent ItemPurchased;
    public static UnityEvent<ProductItem> UpdateItemCount = new UnityEvent<ProductItem>();

    public static void OnBuyButtonPressed(ProductItem item) {
        if (BuyButtonPressed != null) {
            BuyButtonPressed?.Invoke(item);
        }
    }

    public static void OnItemPurchased() {
        if (ItemPurchased != null) {
            ItemPurchased();
        }
    }

    public static void OnUpdateItemCount(ProductItem item) {
        if (UpdateItemCount != null) {
            UpdateItemCount?.Invoke(item);
        }
    }
}
