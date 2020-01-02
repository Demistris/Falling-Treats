using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerSprite : MonoBehaviour
{
    public GameObject Player;
    public ItemStats ItemStats;

    public void Change(Sprite differentSprite)
    {
        if(ItemStats.isItemBought == true)
        {
            Player.GetComponent<SpriteRenderer>().sprite = differentSprite;
        }
    }
}