using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Amount of time this level lasts in seconds")]
    [SerializeField] float levelTime = 10f;

    Slider slider = null;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        slider.value = Time.timeSinceLevelLoad / levelTime;

        bool timerDone = (Time.timeSinceLevelLoad >= levelTime);

        if (timerDone)
        {
            Debug.Log("Level Done");
        }
    }
}
