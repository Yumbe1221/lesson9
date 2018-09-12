using UnityEngine;
using System.Collections;

public class ButtunGenerator : MonoBehaviour
{
    //pushpressPrefabを入れる
    //public GameObject buttun_flick1;
    //pushlongpress1Prefabを入れる
    //public GameObject buttun_flick2;
    //pushlongpress2Prefabを入れる
    //public GameObject buttun_longpress1;
    //pushflick1Prefabを入れる
    //public GameObject buttun_tap1;
    //pushflick2Prefabを入れる
    //public GameObject buttun_tap2;
    //pushtap1Prefabを入れる
    //public GameObject buttun_tap3;

    public GameObject[] buttuns;


    //スタート地点
    public Vector3 start;

    // 時間計測用の変数
    private float delta = 0;

    // キューブの生成間隔
    private float span = 1.0f;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        // span秒以上の時間が経過したかを調べる
        if (this.delta > this.span)
        {
            this.delta = 0;
            // 生成するキューブ数をランダムに決める
            int n = Random.Range(0, buttuns.Length);

            // キューブの生成
            GameObject go = Instantiate (buttuns[n]) as GameObject;
            go.transform.position = start;

            // 次のキューブまでの生成時間を決める
            this.span = Random.Range(2, 3);
        }
        

    }
}