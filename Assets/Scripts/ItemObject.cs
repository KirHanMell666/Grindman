using System;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public Item item;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (item == null)
        {
            Destroy(gameObject);
        }
        spriteRenderer.sprite = item.sprite;
    }
    
    
}
