﻿using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    private void OnClick()
    {
        Button button = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();


        if (button != null)
        {
            ColorBlock colors = button.colors;
            colors.highlightedColor = new Color32(50, 100, 200, 255);
            button.colors = colors;
        }
    }

}