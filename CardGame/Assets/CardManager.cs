using UnityEngine;                               //引用 unity API

public class CardManager : MonoBehaviour         //繼承 MonoBehaviour 可以放在物件上
{
    public Card cardPlayer, cardPC;

    public Sprite[] CardImage;

    // 事件：開始、遊戲開始時執行一次
    private void Start()
    {
        int Pnum = Random.Range(0, 10);
        int Cnum = Random.Range(0, 10);

        Debug.Log("player:" + Pnum);
        Debug.Log("COM:" + Cnum);

        cardPlayer = new Card(Pnum, -2, CardImage[Pnum]);
        cardPC = new Card(Cnum, 2, CardImage[Cnum]);
    }
}