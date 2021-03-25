using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton1 : MonoBehaviour
{
    [SerializeField] GameObject HelpPanel1; //Unityエディタ上でHelpPanel2の枠をアタッチできるように表示する
    [SerializeField] GameObject HelpPanel2; //Unityエディタ上でHelpPanel2の枠をアタッチできるように表示する
    public void Onclick() //「次へ」のボタン(NextButton1)がクリックされたら
    {
        HelpPanel1.SetActive(false); //ヘルプ１：遊び方のポップアップパネルを閉じる
        HelpPanel2.SetActive(true); //ヘルプ２：操作方法のポップアップパネルを表示する
    }
}
