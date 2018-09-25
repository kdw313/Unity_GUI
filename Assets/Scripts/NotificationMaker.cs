using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationMaker : MonoBehaviour {
    
    [SerializeField]
    public GameObject notificationBar;

    /// <summary>
    /// Notifies from bottom.
    /// </summary>
    /// <param name="id">Identifier (0: info, 1: warning).</param>
    public void NotifyFromBottom(int id)
    {
        // TODO: Determine the id of notificaiton and call the notification
        GameObject newNotification;

        newNotification = (GameObject)Instantiate(notificationBar, transform);

    }
}
