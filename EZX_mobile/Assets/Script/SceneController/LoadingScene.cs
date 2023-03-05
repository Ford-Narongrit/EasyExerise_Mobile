using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class LoadingScene : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI loadingtext;

    private bool _isReadytoGo = false;

    void Start()
    {
        // init start function

        _isReadytoGo = true;
    }

    void Update()
    {
        if (_isReadytoGo)
        {
            SceneManager.LoadScene("StartMenuScene");
        }
    }

    public void login()
    {
        // TODO: google auth 
    }
}
