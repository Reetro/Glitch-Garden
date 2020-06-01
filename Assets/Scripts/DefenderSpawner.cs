using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender = null;
    private void OnMouseDown()
    {
        var spawnLocation = GetSquareClick();

        SpawnDefender(spawnLocation);
    }

    private void SpawnDefender(Vector2 SpawnLocation)
    {
        var newRotation = new Quaternion(0, 180, 0, 0);

        GameObject newDefender = Instantiate(defender, SpawnLocation, newRotation) as GameObject;
    }

    private Vector2 GetSquareClick()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);

        return worldPos;
    }
}
