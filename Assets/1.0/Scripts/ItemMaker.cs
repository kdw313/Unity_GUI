using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Item maker.
/// Author: Shawn Kim
/// Created Date: 2018-09-25
/// Last Modified: 2018-09-25
/// </summary>
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
