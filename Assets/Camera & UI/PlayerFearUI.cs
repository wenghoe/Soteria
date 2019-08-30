using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class PlayerFearUI : MonoBehaviour
{

    RawImage fearRawImage;
    Player player;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<Player>();
        fearRawImage = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        float yValue = -(player.fearAsPercentage / 2f) - 0.5f;
        fearRawImage.uvRect = new Rect(0f, yValue, 1f, 0.5f); // vertical bar like in DL
    }
}
