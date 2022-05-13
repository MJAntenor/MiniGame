using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static MainMenu Instance;

    [SerializeField] Button StartGameButton;
    // Start is called before the first frame update
    void Start()
    {
        StartGameButton.onClick.AddListener(StartGame);
    }

    public void StartGame()
    {
        Debug.Log("Restart");
        SceneManager.LoadScene(1);
    }
}
