using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkySystem : MonoBehaviour
{
    //角度を入れる変数
    [SerializeField]
    private float sunPos;

    //Skyboxを入れる変数、[]があると複数入れられるようになる
    public Material[] skybox;

    // Update is called once per frame
    void Update()
    {
        //X軸を回転させる
        transform.eulerAngles = new Vector3(-sunPos, 0, 0);

        //1日のスピードを調節する
        sunPos += Time.deltaTime * 1;

        //0度以上72度未満の時に一つ目のSkyboxを出す
        if (sunPos >= 0 && 60 > sunPos)
            RenderSettings.skybox = skybox[0];

        //elseがないと切り替わらない
        else if (sunPos >= 60 && 120 > sunPos)
            RenderSettings.skybox = skybox[1];

        else if (sunPos >= 120 && 180 > sunPos)
            RenderSettings.skybox = skybox[2];

        else if (sunPos >= 180 && 240 > sunPos)
            RenderSettings.skybox = skybox[3];

        else if (sunPos >= 240 && 300 > sunPos)
            RenderSettings.skybox = skybox[4];

        else if (sunPos >= 300 && 360 > sunPos)
            RenderSettings.skybox = skybox[5];

        //360度以上になったら0に戻す
        if (sunPos > 360)
            sunPos = 0;
    }
}

//[SerializeField]を宣言されている変数の上に置くとその変数がprivateなのにInspectorに表示されて再生時の変数の中身をチェックできます。
//360度を6等分し、その角度の時だけ対応するSkyboxが出るようにしました。
//if文は中に入るコードが一行だと{}が要りません。