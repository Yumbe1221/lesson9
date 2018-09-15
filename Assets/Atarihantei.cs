using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atarihantei : MonoBehaviour {
    
    ButtonController activeController;

    //今衝突しているボタン
    public ButtonController activeButton;


    //当たり判定に入ったらactiveControllerに代入する
    void OnTriggerEnter2D(Collider2D other)
    {
        activeController = other.gameObject.GetComponent<ButtonController>();
    }


    //当たり判定を抜けたらactiveControllerを空(null)にする
    void OnTriggerExit2D(Collider2D other)
    {
        activeController = null;
    }

	
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
