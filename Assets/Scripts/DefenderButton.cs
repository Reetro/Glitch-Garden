﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    SpriteRenderer spriteRender = null;

    private void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (!spriteRender) { return; }

        var buttons = FindObjectsOfType<DefenderButton>();

        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(75, 75, 75, 255);
        }

        spriteRender.color = Color.white;
    }
}
