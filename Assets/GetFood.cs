using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFood : MonoBehaviour
{
    private int point = 0; //総カロリーの箱
    private GameObject pointText; //右上に出す取得カロリー合計数のUI
    private void Start()
    {
        pointText = GameObject.Find("CalorieTotalUI"); //右上に表示するやつを探していれる
        pointText.GetComponent<TextMesh>().text = point + " kcal"; //表示するカロリーを文字数にして入れている
    }

    public int GetPoint() //他のでも見れるけどポイントを他で書き換えられないようにした
    {
        return point;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit) //オブジェクトに当たったときに動く
    {
        if(hit.gameObject.tag == "Food")
        {
            DestroyObject food;
            food = hit.gameObject.GetComponent<DestroyObject>(); //Foodにはデストロイオブジェクト.csのスクリプトが読み込まれる
            point += food.calorie; //デストロイオブジェクトのスクリプトのpublic int Carorieの数字をポイント変数に加算する
            pointText.GetComponent<TextMesh>().text = point + " kcal"; //右上のスコアにポイントを表示する
            GetComponent<AudioSource>().Play();
            //Destroy(hit.gameObject); //バナナを消す
        }
    }
}
