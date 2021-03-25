using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    public static float CountDownTime; //カウントダウンタイム　外部からも利用できるようにstatic宣言
    public Text TextCountDown; // 表示用テキストUI　テキストUIにカウントダウンタイムを表示するため、Text型の変数が一つ必要になります。

    // Start is called before the first frame update
    void Start()
    {
        CountDownTime = 720.0F;    // 12分のカウントダウン(開始時間)
    }
    
    // Update is called once per frame
    void Update()
    {
        string min = String.Format("{0:D2}", (int)CountDownTime / 60);
        string sec = String.Format("{0:D2}", (int)CountDownTime % 60);

        TextCountDown.text = String.Format("タイムアップまで" + Environment.NewLine + "{0}:{1}", min,sec); // カウントダウンタイム表示

        CountDownTime -= Time.deltaTime; // 開始時間から経過時間を引く

        if (CountDownTime <= 0.0F) // 0.0秒以下になったら表示を0.0へ
        {
            CountDownTime = 0.0F;
            FadeManager.Instance.LoadScene("Result", 0.3f);
            //SceneManager.LoadScene("Result");
        }
    }
}
//もしカウントダウンがゼロになったら、ピピー！終了！そこまで！みたいな演出をしたい。
//リザルト演出後、カービィの獲得したお宝をエンドロールして、エンディングというかゲーム終了的な。←タイトルに戻る、とか。
//if(time > 0 ) //イコールが入ると0も含まれる
//{
//    time -= Time.deltaTime;
//}
//int t = Mathf.FloorToInt(time);
//Text uiText = GetComponent<Text>();
//uiText.text = "タイムアップまで:" + t;
//▼他にやること▼
//ステージ１からステージ２へ遷移するスクリプトを作る。
//タイムアップ後のリザルト画面(もしくは演出)で、獲得したアイテム(お宝)を読み込んで、そのUIと価値(金額)を表示して、合計はいくらでした　と表示する。
//次のステージへワープしますか？(ワープしてもここに再び戻れます　的な一言も添えて。)