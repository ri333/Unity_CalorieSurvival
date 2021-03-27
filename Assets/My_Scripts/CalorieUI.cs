using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalorieUI : MonoBehaviour
{
    //プレイヤーと当たったからカロリー表示しろと指示を出してきた食べ物の位置を取得する関数
    public void Kottikite(Vector3 position) //Vector3はintと同じ型 kottikiteはpositionというかごを持った人　positionには座標が入ってくる(これ渡すからこれやってのコレの部分)
    {
        transform.position = position; //その場所に飛ぶ カロリーUIの位置をこっち来いの位置に持っていく
        Debug.Log("OK");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = Vector3.up * 1.0f;
        transform.Translate(velocity * Time.deltaTime);
        transform.LookAt(Camera.main.transform);
        transform.Rotate(new Vector3(0, -180f, 0));
    }
}
