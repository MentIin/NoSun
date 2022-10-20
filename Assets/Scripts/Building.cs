using System;
using UnityEngine;

public class Building : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private int[] renderedOrders = {0, 2};
    protected Collider2D _collider;

    protected void Awake()
    {
        _collider = GetComponent<Collider2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    protected void Update()
    {
        SetRendererOrder();
    }

    private void SetRendererOrder()
    {
        if (GameManager.current.player.pos.y < _collider.bounds.center.y)
        {
            _spriteRenderer.sortingOrder = renderedOrders[0];
        }
        else
        {
            _spriteRenderer.sortingOrder = renderedOrders[1];
        }
    }
}
