using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Our level timer in Seonds")]
    [SerializeField] float levelTime = 10;
    bool triggeredLevelFiished = false;
    
    // Update is called once per frame
    void Update()
    {
        if (triggeredLevelFiished)
        {
            return;
        }
        
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        bool timerFinished = (Time.timeSinceLevelLoad >= levelTime);
        if (timerFinished)
        {
            FindObjectOfType<LevelController>().LevelTimerFinished();
            triggeredLevelFiished = true;
        }
    }
}
