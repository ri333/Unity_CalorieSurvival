using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public string target_tag; 
    public short calorie;

    [SerializeField] GameObject CalorieUI; 

    void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag == target_tag)
        {
            CalorieUI CaloriePoint = CalorieUI.GetComponent<CalorieUI>();
            CaloriePoint.Kottikite(transform.position, calorie); //食べ物の位置をこっちきてに教えてる
            collision.gameObject.GetComponent<AudioSource>().Play(); //音を鳴らす
            Destroy(gameObject); //食べ物のオブジェクトを消す
            CalorieUI.SetActive(true); //セットアクティブでCalorieUIをtrueにしておくことで当たったときだけUIを表示する
        }
    }
}