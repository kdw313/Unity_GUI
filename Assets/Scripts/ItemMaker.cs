using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMaker : MonoBehaviour {

    [SerializeField]
    public GameObject item;

    public static int numberOfItems;

    /// <summary>
    /// Adds a item to list.
    /// </summary>
    private void AddToList()
    {
        GameObject newItem;

        newItem = (GameObject)Instantiate(item, transform);
        numberOfItems++;

    }
}
