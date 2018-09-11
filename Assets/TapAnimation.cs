using System.Collections;
using System.Collections.Generic;
using TouchScript.Gestures;
using System;
using UnityEngine;

public class TapAnimation : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    public TapGesture tap1;
    public TapGesture tap2;
    public TapGesture tap3;
    public LongPressGesture longpress1;
    public FlickGesture flick1;
    public FlickGesture flick2;

    private TapGesture tapgesture;

    //アニメーションするためのコンポーネントを入れる
    private Animator myAnimator;

    //Unityちゃんを移動させるコンポーネントを入れる
    private Rigidbody myRigidbody;

    //ジャンプするための力
    private float upForce = 50.0f;

    //地面に触れているか判定するため
    bool ground;

    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        this.myAnimator = unitychan.GetComponent<Animator>();
        //Rigidbodyコンポーネントを取得
        this.myRigidbody = unitychan.GetComponent<Rigidbody>();
    }


    // オブジェクトが有効化されたときにイベントハンドラを登録する
    private void OnEnable()
    {
        tap1.Tapped += taphandler1;
        tap2.Tapped += taphandler2;
        tap3.Tapped += taphandler3;
        longpress1.LongPressed += longpresshandler1;
        flick1.Flicked += flickhandler1;
        flick2.Flicked += flickhandler2;
    }

    // タップイベントのイベントハンドラ(何を処理させたいか)
    private void taphandler1(object sender, EventArgs e)
    {
        Debug.Log("Tap1を検知");

        //ジャンプアニメを再生
        this.myAnimator.SetTrigger("Jumping1");
        //Unityちゃんに上方向の力を加える
        this.myRigidbody.AddForce(this.transform.up * this.upForce);
           
    }

    // タップイベントのイベントハンドラ(何を処理させたいか)
    private void taphandler2(object sender, EventArgs e)
    {
        Debug.Log("Tap2を検知");

        //ジャンプアニメを再生
        this.myAnimator.SetTrigger("Posing1");
        //Unityちゃんに上方向の力を加える
        this.myRigidbody.AddForce(this.transform.up * this.upForce);

    }

    // タップイベントのイベントハンドラ(何を処理させたいか)
    private void taphandler3(object sender, EventArgs e)
    {
        Debug.Log("Tap3を検知");

        //ジャンプアニメを再生
        this.myAnimator.SetTrigger("Posing3");
        //Unityちゃんに上方向の力を加える
        this.myRigidbody.AddForce(this.transform.up * this.upForce);

    }


    // 長押しイベントのイベントハンドラ(何を処理させたいか)
    private void longpresshandler1(object sender, EventArgs e)
    {
        Debug.Log("Longpress1を検知");

        //ポーズ１アニメを再生
        this.myAnimator.SetTrigger("Posing2");

    }


    // フリックイベントのイベントハンドラ(何を処理させたいか)
    private void flickhandler1(object sender, EventArgs e)
    {
        Debug.Log("Flick1を検知");

        //ポーズ２アニメを再生
        this.myAnimator.SetTrigger("Posing4");
    }

    // フリックイベントのイベントハンドラ(何を処理させたいか)
    private void flickhandler2(object sender, EventArgs e)
    {
        Debug.Log("Flick2を検知");

        //ポーズ２アニメを再生
        this.myAnimator.SetTrigger("Posing5");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}