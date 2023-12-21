using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public TMPro.TextMeshProUGUI timer;

    // Update is called once per frame
    void Update()
    {
        timer.text = timer.text + minutes + ":" + seconds;
        seconds -= Time.deltaTime;
        if (seconds < 0)
        {
            if (minutes < 0) {
                minutes -= 1;
                seconds = 59;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

    }
}
