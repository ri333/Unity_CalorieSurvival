using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToTitleButton : MonoBehaviour
{
    public void Onclick()
    {
        FadeManager.Instance.LoadScene("Title", 0.3f);
    }
}
