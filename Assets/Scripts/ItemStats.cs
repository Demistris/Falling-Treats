using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemStats : MonoBehaviour
{
    public int Price;
    public TextMeshProUGUI PriceText;
    public GameObject Texts;
    public bool isItemBought = false;

    private Image image;

    void Start()
    {
        PriceText.text = Price.ToString();
    }

    public void BuyingItems()
    {
        if(PlayerStats.Diamonds >= Price)
        {
            isItemBought = true;
            PlayerStats.Diamonds -= Price;
        }

        if (isItemBought == true)
        {
            image = GetComponent<Image>();
            image.color = Color.white;
            var tempColor = image.color;
            tempColor.a = 0.862f;
            image.color = tempColor;

            Texts.SetActive(false);
        }
    }
}
