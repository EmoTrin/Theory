using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
<<<<<<< Updated upstream:Assets/Scripts/MenuUI.cs
public class MenuUI : MonoBehaviour
=======

public class MainController : MonoBehaviour
>>>>>>> Stashed changes:Assets/Scripts/MainController.cs
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}

