using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Color newColor = new Color32(0, 0, 0, 255);

    public void OnClick()
    {
        Button button = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();


        Debug.Log(button + "Clickced");

        if (button != null)
        {
            ColorBlock colors = button.colors;
            colors.highlightedColor = new Color32(50, 100, 200, 255);
            button.colors = colors;
        }
    }

}