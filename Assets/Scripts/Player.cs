using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _speed=2;
    private Animator _anim;
    private Inventory _inventory;
    private UI_Inventory _uiInventory;
    private Collider2D _collider;

    private void Awake()
    {
        _collider = GetComponent<Collider2D>();
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
        _inventory = new Inventory();
        _uiInventory = GameManager.current.uiInventory;
        
        _uiInventory.SetInventory(_inventory);
    }


    public void SetDirection(float x, float y)
    {
        // x, y in [-1, 1]
        _rb.velocity = new Vector2(x * _speed, y * _speed);
        SetAnimator(x, y);
    }

    private void SetAnimator(float x, float y)
    {
        _anim.SetFloat("speed_x", x);
        _anim.SetFloat("speed_y", y);
    }

    public Vector2 pos
    {
        get
        {
            return _collider.bounds.center;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Item"))
        {
            Collectibles item = col.GetComponent<Collectibles>();
            _inventory.AddItem(item.GetItem());
            item.Die();
        }
    }
}
