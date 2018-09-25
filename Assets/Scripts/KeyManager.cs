using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour {
    
    [SerializeField]
    public ItemMaker itemMaker;

    [SerializeField]
    public NotificationMaker notificationMaker;

    // timer to make a delay
    public float timestamp = 0f;
    public float delay = 0.2f;


	// Use this for initialization
	void Awake () {
        if(itemMaker == null)
            itemMaker = GameObject.Find("Content").GetComponent<ItemMaker>();

        if(notificationMaker == null)
            notificationMaker = GameObject.Find("CanvasNotification").GetComponent<NotificationMaker>();
        
	}

    void Update()
    {
        if(Time.time >= timestamp)
        {
            if (Input.GetKey(KeyCode.Q)) 
            {
                itemMaker.AddToList();
                timestamp = Time.time + delay;
            }

            if (Input.GetKey(KeyCode.A))
            {
                notificationMaker.NotifyFromBottom(0);
                timestamp = Time.time + delay;
            }

            if (Input.GetKey(KeyCode.S))
            {
                notificationMaker.NotifyFromBottom(1);
                timestamp = Time.time + delay;
            }
        }

    }



}
