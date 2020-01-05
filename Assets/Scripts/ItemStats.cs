using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemStats : MonoBehaviour
{
    public int Id;
    public int Price;
    public TextMeshProUGUI PriceText;
    public GameObject Texts;
    private bool itemIsAlreadyBought = false;
    public bool isItemBought
    {
        get { return PlayerPrefs.GetInt("BoughtItem" + Id) == 1 ? true : false; }
        set { PlayerPrefs.SetInt("BoughtItem" + Id, value ? 1 : 0); }
    }

    private Image image;

    void Start()
    {
        PriceText.text = Price.ToString();
        RefreshBoughtState();
    }

    public void BuyItems()
    {
        if(itemIsAlreadyBought == false)
        {
            if (PlayerStats.Diamonds >= Price)
            {
                isItemBought = true;
                PlayerStats.Diamonds -= Price;
                PlayerPrefs.SetInt("Diamonds", PlayerStats.Diamonds);
            }
        }

        RefreshBoughtState();
    }

    private void RefreshBoughtState()
    {
        if (isItemBought == true)
        {
            itemIsAlreadyBought = true;
            image = GetComponent<Image>();
            image.color = Color.white;
            var tempColor = image.color;
            tempColor.a = 0.862f;
            image.color = tempColor;

            Texts.SetActive(false);
        }
    }
}