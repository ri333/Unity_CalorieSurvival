using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public string target_tag; //まず変数を用意する
    public float deleteTime = 0.01f; //UI消す時間
    public int calorie;

    [SerializeField] GameObject CalorieUI; //インスペクタに表示する変数

    void OnCollisionEnter(Collision collision) //コリジョンに当たったら〜をする　関数
    {
        if (collision.gameObject.tag == target_tag) //もしオブジェクトのタグが○○だったら、(ここではバナナ)消す
        {   
            collision.gameObject.GetComponent<AudioSource>().Play();
            Destroy(gameObject); //食べ物のオブジェクトを消す
            CalorieUI.SetActive(true); //セットアクティブでCalorieUIをtrueにしておくことで当たったときだけUIを表示する
            Destroy(CalorieUI, deleteTime); //上記で当たったらデリートタイムが経過したらUIを消す
        }
    }   　       　　　
}
