using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "Item-", menuName = "ScriptableObjects/ItemData")]
public class ItemData : ScriptableObject
{
    public ItemId itemId;
    public string Name;
    public Sprite imgItem;
}
