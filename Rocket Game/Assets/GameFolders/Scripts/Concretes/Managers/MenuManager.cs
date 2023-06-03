using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public void levelSelect(int levelNumber)
    {
        SceneManager.LoadScene("Level" + levelNumber);
    }

    public Button level1_button, level2_button, level3_button, level4_button, level5_button, level6_button, level7_button, level8_button, level9_button, level10_button, level11_button, level12_button, level13_button, level14_button, level15_button, level16_button, level17_button, level18_button, level19_button, level20_button;
    public static bool level1, level2, level3, level4, level5, level6, level7, level8, level9, level10, level11, level12, level13, level14, level15, level16, level17, level18, level19, level20;

    public void Start()
    {
        level1 = true;
    }

    private void Update()
    {
        if(level2 ==true)
        {
            level2_button.interactable = true;
        }

        if (level3 == true)
        {
            level3_button.interactable = true;
        }

        if (level4 == true)
        {
            level4_button.interactable = true;
        }

        if (level5 == true)
        {
            level5_button.interactable = true;
        }

        if (level6 == true)
        {
            level6_button.interactable = true;
        }

        if (level7 == true)
        {
            level7_button.interactable = true;
        }

        if (level8 == true)
        {
            level8_button.interactable = true;
        }

        if (level9 == true)
        {
            level9_button.interactable = true;
        }

        if (level10 == true)
        {
            level10_button.interactable = true;
        }

        if (level11 == true)
        {
            level11_button.interactable = true;
        }

        if (level12 == true)
        {
            level12_button.interactable = true;
        }

        if (level13 == true)
        {
            level13_button.interactable = true;
        }

        if (level14 == true)
        {
            level14_button.interactable = true;
        }

        if (level15 == true)
        {
            level15_button.interactable = true;
        }

        if (level16 == true)
        {
            level16_button.interactable = true;
        }

        if (level17 == true)
        {
            level17_button.interactable = true;
        }

        if (level18 == true)
        {
            level18_button.interactable = true;
        }

        if (level19 == true)
        {
            level19_button.interactable = true;
        }

        if (level20 == true)
        {
            level20_button.interactable = true;
        }
    }
}
