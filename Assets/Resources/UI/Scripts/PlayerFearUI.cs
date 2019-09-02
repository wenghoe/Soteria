using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class PlayerFearUI : MonoBehaviour
{

    Image fearImage;
    Player player;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<Player>();
        fearImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        float amount = player.fearAsPercentage;
        fearImage.fillAmount = amount;
    }
}
