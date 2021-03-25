using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPointPopup : MonoBehaviour
{
    public string target_tag; //まず変数を用意する
    [SerializeField] GameObject StartPointUI; //インスペクタに表示する変数

    void OnCollisionEnter(Collision collision) //コリジョンに当たったら〜をする　関数
    {
        if (collision.gameObject.tag == target_tag) //もしオブジェクトのタグが○○だったら、(ここではバナナ)消す
        {   
            StartPointUI.SetActive(true); //セットアクティブでCalorieUIをtrueにしておくことで当たったときだけUIを表示する
        }
    }
}
