using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void Onclick()
    {
        //SceneManager.LoadScene("Stage1");
        FadeManager.Instance.LoadScene ("Stage1", 0.3f);
    }
}