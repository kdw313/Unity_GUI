using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Date : MonoBehaviour
{
    private System.DateTime curDate;

    [SerializeField]
    public Text date;
    [SerializeField]
    public Text time;

    void Start()
    {
        UpdateGUIDateTime(System.DateTime.Now);
        StartCoroutine(OnPerMin());
    }

    /// <summary>
    /// Coroutine function that check the time call update every 0.5 sec
    /// </summary>
    /// <returns>The per minimum.</returns>
    private IEnumerator OnPerMin()
    {
        while(true)
        {
            // update time
            curDate = System.DateTime.Now;


            // if one minute is passed
            if((curDate.Second % 60) == 0)
            {
                //Debug.Log("one minute passed: " + curDate);

                UpdateGUIDateTime(curDate);
            }


            // every 0.5 second
            yield return new WaitForSecondsRealtime(0.5f);
        }
    }

    /// <summary>
    /// Updates the GUI's Date and time.
    /// </summary>
    /// <param name="newDateTime">New Date and Time.</param>
    private void UpdateGUIDateTime(System.DateTime newDateTime)
    {
        // safety
        if (date != null && time != null)
        {
            date.text = newDateTime.ToString("dd MM yyyy");
            time.text = newDateTime.ToString("HH:mm");
        }
        
    }
}