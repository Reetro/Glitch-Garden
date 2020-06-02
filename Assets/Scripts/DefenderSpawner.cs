using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender = null;
    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClick());
    }

    private void SpawnDefender(Vector2 spawnLocation)
    {
        var newRotation = new Quaternion(0, 180, 0, 0);

        GameObject newDefender = Instantiate(defender, spawnLocation, newRotation) as GameObject;
    }

    private Vector2 GetSquareClick()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);

        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);

        return new Vector2(newX, newY);
    }
}
