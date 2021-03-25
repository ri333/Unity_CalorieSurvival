using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    [SerializeField] GameObject HelpPanel3; //Unityエディタ上でHelpPanel1の枠をアタッチできるように表示する
    public void Onclick() //「Help」のボタンがクリックされたら
    {
        HelpPanel3.SetActive(false); //ヘルプ１：遊び方のポップアップパネルを表示する
    }
}
