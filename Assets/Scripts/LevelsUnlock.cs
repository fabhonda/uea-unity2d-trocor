using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsUnlock : MonoBehaviour
{

    //public List<Sprite> buttonImages;
    public List<Button> buttons;

    void Start()
    {
        for (int j = 0; j < buttons.Count; j++)
        {
            if (j != 0) buttons[j].interactable = false;      
            else buttons[j].interactable = true;          
        }

        for (int i = 1; i < buttons.Count; i++)
        {
            if (PlayerPrefs.GetInt("Level" + i.ToString()) == 1)
            {
                if (i < buttons.Count - 1) buttons[i].interactable = true;   
            }
        }
    }

    public void reset()
    {
        PlayerPrefs.DeleteAll();
    }

}
