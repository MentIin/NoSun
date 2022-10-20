using UnityEngine;

public class Collectibles : MonoBehaviour
{
    protected SpriteRenderer _spriteRenderer;
    private int[] renderedOrders = {0, 2};
    private Item _item;

    public static Collectibles Spawn(Vector2 position, Item item)
    {
        Transform transform = Instantiate(ItemAssets.Instance.itemPref, position, Quaternion.identity);

        Collectibles col = transform.GetComponent<Collectibles>();
        col.SetItem(item);

        return col;

    }

    protected void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void SetItem(Item item)
    {
        _item = item;
        
    }

    public Item GetItem()
    {
        return _item;
    }

    public void Die()
    {
        Destroy(this.gameObject);
    }

    private void SetIcon()
    {
        _spriteRenderer.sprite = _item.GetSprite();
    }
}