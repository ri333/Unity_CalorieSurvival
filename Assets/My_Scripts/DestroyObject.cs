using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public string target_tag; //まず変数を用意する
    public float deleteTime = 0.01f; //UI消す時間
    public short calorie;

    [SerializeField] GameObject CalorieUI; //インスペクタに表示する変数

    void OnCollisionEnter(Collision collision) //コリジョンに当たったら〜をする　関数
    {
        if (collision.gameObject.tag == target_tag) //もしオブジェクトのタグが○○だったら、(ここではバナナ)消す
        {
            CalorieUI CaloriePoint = CalorieUI.GetComponent<CalorieUI>();
            CaloriePoint.Kottikite(transform.position); //食べ物の位置をこっちきてに教えてる
            collision.gameObject.GetComponent<AudioSource>().Play(); //音を鳴らす
            Destroy(gameObject); //食べ物のオブジェクトを消す
            CalorieUI.SetActive(true); //セットアクティブでCalorieUIをtrueにしておくことで当たったときだけUIを表示する
            Destroy(CalorieUI, deleteTime); //上記で当たったらデリートタイムが経過したらUIを消す
        }
    }   　       　　　
}
//calorieUIを一個一個に入れる方法を確認する　このままだとカロリーUIを都度アタッチしないとカロリーUIが表示されない

//