using UnityEngine;                                        //引用 unity API

public class GameManager : MonoBehaviour                  //繼承 MonoBehaviour 可以放在物件上
{
    public Card NineMare = new Card(10,15f,loc);                        //產生 Ship 物件

    
    private void Start()                                  // 事件：開始、遊戲開始時執行一次
    {
        
    }
}