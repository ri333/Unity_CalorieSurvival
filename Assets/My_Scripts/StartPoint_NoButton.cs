using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint_NoButton : MonoBehaviour
{
    [SerializeField] GameObject StartPointUI; //Unityエディタ上でStartPointUIの枠をアタッチできるように表示する
    public void Onclick() //Noがクリックされたら
    {
        StartPointUI.SetActive(false); //終了しますか？のポップアップパネルを閉じる
    }
}
