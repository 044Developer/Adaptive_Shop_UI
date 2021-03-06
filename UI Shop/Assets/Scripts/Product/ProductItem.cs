using UnityEngine;

[CreateAssetMenu(menuName = "Product/Product Item")]
public class ProductItem : ScriptableObject {

    private const int DefaultCountValue = 1;
    [Header("Item Data")]
    [SerializeField]
    private string _name;
    [SerializeField]
    private Sprite _texture;
    [SerializeField]
    private float _price;
    [SerializeField]
    private int _count;

    private bool _hasOpened;

    public string Name { get => _name; }
    public Sprite Texture { get => _texture; }
    public float Price { get => _price; }
    public int Count { get => _count; }
    public bool HasOpened { get => _hasOpened; }

    private void OnEnable() {
        _count = DefaultCountValue;
        _hasOpened = false;
    }

    public bool CheckNewItem() {
        if (HasOpened) {
            _count++;
            return true;
        }
        else {
            _hasOpened = true;
            return false;
        }
    }

}
