using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;

    TextMeshProUGUI textDisplay = null;

    void Start()
    {
        textDisplay = GetComponent<TextMeshProUGUI>();

        UpdateDisplay();
    }

    public void AddStars(int amount)
    {
        stars += amount;

        UpdateDisplay();
    }
    
    public void RemoveStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;

            UpdateDisplay();
        }
    }
    public bool HasEnoughStars(int amount)
    {
        return stars >= amount;
    }

    private void UpdateDisplay()
    {
        textDisplay.text = stars.ToString();
    }
}
