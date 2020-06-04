using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab = null;

    SpriteRenderer spriteRender = null;
    DefenderSpawner spawner = null;

    private void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
        spawner = FindObjectOfType<DefenderSpawner>();

        SetCostText();
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
        spawner.SetSelectedDefender(defenderPrefab);
    }

    private void SetCostText()
    {
        TextMeshProUGUI costText = GetComponentInChildren<TextMeshProUGUI>();
        
        if (!costText)
        {
            Debug.LogError(name + "has no cost text");
        }
        else
        {
            costText.text = defenderPrefab.GetStarCost().ToString();
        }
    }
}
