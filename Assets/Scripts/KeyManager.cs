using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour {

    [SerializeField]
    public GameObject item;
    
    public static int numberOfItems;


    // timer to make a delay
    public float timestamp = 0f;
    public float delay = 0.2f;

	// Use this for initialization
	void Start () {
        numberOfItems = 0;
	}

    void Update()
    {
        if(Time.time >= timestamp)
        {
            // TODO: Add item to the list
            if (Input.GetKey(KeyCode.Q)) 
            {
                AddToList();
                timestamp = Time.time + delay;
            }

            // TODO: Notification normal
            if (Input.GetKey(KeyCode.A))
            {

                timestamp = Time.time + delay;
            }

            // TODO: Notification warning
            if (Input.GetKey(KeyCode.S))
            {

                timestamp = Time.time + delay;
            }
        }

    }


    void AddToList()
    {
        GameObject newItem;

        newItem = (GameObject)Instantiate(item, transform);
        numberOfItems++;

    }


    void NotifyFromBottom(int id)
    {
        // TODO: Determine the id of notificaiton and call the notification

    }

}
