using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class PlayerHealthDisplay : MonoBehaviour
{
    [SerializeField] int health = 5;

    TextMeshProUGUI textDisplay = null;
    LevelLoader levelLoader = null;

    void Start()
    {
        textDisplay = GetComponent<TextMeshProUGUI>();

        UpdateDisplay();
    }

    public void RemoveHealth(int amount)
    {
        health -= amount;
        UpdateDisplay();

        if (health <= 0)
        {
            LoadGameOver();
        }
    }

    public void AddHealth(int amount)
    {
        health += amount;
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        textDisplay.text = health.ToString();
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("Game Over");
    }
}
