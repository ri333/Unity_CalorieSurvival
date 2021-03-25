using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPoint_YesButton : MonoBehaviour
{
    public void Onclick()
    {
        //SceneManager.LoadScene("Title");
        FadeManager.Instance.LoadScene ("Title", 0.3f);
    }
}