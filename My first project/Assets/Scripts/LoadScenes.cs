using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public Button button;
    public string sceneName;
    private void Start()
    {
        button.onClick.AddListener(OnButtonClick); // Adding a Listner to call OnButtonClick function whenever we click on button
    }
    private void OnButtonClick() // Function used to change between scenes using scene name
    {
        SceneManager.LoadScene(sceneName);
    }
}
