using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpButtton : MonoBehaviour
{
    [SerializeField] GameObject HelpPanel1; //Unityエディタ上でHelpPanel1の枠をアタッチできるように表示する
    public void Onclick() //「Help」のボタンがクリックされたら
    {
        HelpPanel1.SetActive(true); //ヘルプ１：遊び方のポップアップパネルを表示する
    }
}
