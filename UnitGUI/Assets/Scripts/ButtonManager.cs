using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        GameObject button = EventSystem.current.currentSelectedGameObject;

        if (button != null)
        {
            Debug.Log(button + "Clickced");
            button.GetComponent<Image>().color = new Color32(20, 120, 220, 255);
            // TODO: Activate the item
        }
    }

}