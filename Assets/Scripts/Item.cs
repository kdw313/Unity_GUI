using System.Collections;
using UnityEngine;

public class Item
{
    bool IsSelected{
        get;
        set;
    }
    string Title{
        get;
        set;
    }
    string ClientName {
        get;
        set;
    }

    public static Color32 DEFAULT_COLOR = new Color32(0, 0, 0, 255);
    public static Color32 SELECTED_COLOR = new Color32(80, 120, 220, 255);

    public Item()
    {
        IsSelected = false;
        Title = "Project Name";
        ClientName = "Client Name";
    }


    public void UpdateThis()
    {
        
    }
    
}
