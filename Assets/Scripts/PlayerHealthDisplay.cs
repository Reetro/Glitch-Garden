using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class PlayerHealthDisplay : MonoBehaviour
{
    [SerializeField] float baseLives = 3;

    float Lives;
    TextMeshProUGUI textDisplay = null;

    void Start()
    {
        Lives = baseLives - PlayerPrefsController.GetDifficulty();

        textDisplay = GetComponent<TextMeshProUGUI>();

        UpdateDisplay();
    }

    public void RemoveHealth(int amount)
    {
        Lives -= amount;
        UpdateDisplay();

        if (Lives <= 0)
        {
            FindObjectOfType<LevelController>().HandelLose();
        }
    }

    public void AddHealth(int amount)
    {
        Lives += amount;
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        textDisplay.text = Lives.ToString();
    }
}
