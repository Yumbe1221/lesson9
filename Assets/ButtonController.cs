using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

        public enum ButtonType{

        tap1,
        tap2,
        tap3,
        flick1,
        flick2,
        longpress1
            
        }

        public ButtonType button;


        // ボタンの移動速度
        private float speed = 0.03f;

        // 消滅位置
        private float deadLine = 150;
        

        // Use this for initialization
        void Start(){
        
        }

        // Update is called once per frame
        void Update () {

                // キューブを移動させる
                transform.Translate (0, this.speed, 0);
                
                // 画面外に出たら破棄する
                if (transform.position.y > this.deadLine){
                        Destroy (gameObject);
                }
        }
}