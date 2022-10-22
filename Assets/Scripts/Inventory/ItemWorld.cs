using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWorld : MonoBehaviour
{
    protected SpriteRenderer _spriteRenderer;
    private int[] renderedOrders = {0, 2};
    private Item _item;

    public static ItemWorld Spawn(Vector2 position, Item item)
    {
        Transform transform = Instantiate(ItemAssets.Instance.itemPref, position, Quaternion.identity);

        ItemWorld col = transform.GetComponent<ItemWorld>();
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
        SetIcon();
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
