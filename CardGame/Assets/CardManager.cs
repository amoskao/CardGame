using UnityEngine;                                        //引用 unity API

public class CardManager : MonoBehaviour                  //繼承 MonoBehaviour 可以放在物件上
{
    public Card cardPlayer, cardPC;

    public Sprite Image9, Image3;


    private void Start()                                  // 事件：開始、遊戲開始時執行一次
    {
        cardPlayer = new Card(10, -5f, Image9);
        cardPC = new Card(3, 5, Image3);
    }
}