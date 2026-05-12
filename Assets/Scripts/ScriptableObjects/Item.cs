using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Items/Item")]
public class Item : ScriptableObject
{
    public int id;
    public string itemName;
    public Sprite sprite;
    public int maxStack;
    public string description;
}
