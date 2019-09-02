using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class PlayerSkillUI : MonoBehaviour
{

    RawImage skillRawImage;
    Player player;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<Player>();
        skillRawImage = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        float yValue = -(player.skill1AsPercentage / 2f) - 0.5f;
        skillRawImage.uvRect = new Rect(0f, yValue, 1f, 0.5f); // vertical bar like in DL
    }
}
