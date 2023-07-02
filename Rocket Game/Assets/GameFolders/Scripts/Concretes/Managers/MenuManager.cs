using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button[] lvlButtons;
    int levelUnclocked;

    private void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelUnlocked", 2);

        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 2 > levelAt)
            {
                lvlButtons[i].interactable = false;
            }
        }

        for (int i = 0; i < levelUnclocked; i++)
        {
            if (i + 2 > levelAt)
            {
                lvlButtons[i].interactable = true;
            }


        }

    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
