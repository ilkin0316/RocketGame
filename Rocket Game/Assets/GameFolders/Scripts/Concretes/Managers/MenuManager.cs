using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void levelSelect(int levelNumber)
    {
        SceneManager.LoadScene("Level" + levelNumber);
    }
}
