using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Amount of time this level lasts in seconds")]
    [SerializeField] float levelTime = 10f;

    Slider slider = null;
    bool triggerdLevelFinish = false;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        if (!triggerdLevelFinish)
        {
            slider.value = Time.timeSinceLevelLoad / levelTime;

            bool timerDone = (Time.timeSinceLevelLoad >= levelTime);

            if (timerDone)
            {
                FindObjectOfType<LevelController>().LevelTimerFinished();
                triggerdLevelFinish = true;
            }
        }
    }
}
