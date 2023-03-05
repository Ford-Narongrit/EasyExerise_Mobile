using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    [SerializeField] private Animator startSceneAnimator;

    public void OnClickPlay()
    {
        startSceneAnimator.SetTrigger("play");
    }

    public void OnClickSetting()
    {
        startSceneAnimator.SetTrigger("setting");
    }

    public void OnClickHealth()
    {
        startSceneAnimator.SetTrigger("health");
    }

    public void OnClickQRcode()
    {
        SceneManager.LoadScene("QRcodeConnectScene");
    }
}
