using UnityEngine;                               //引用 unity API

public class CardManager : MonoBehaviour         //繼承 MonoBehaviour 可以放在物件上
{
    public Card cardPlayer, cardPC;

    public Sprite[] CardImage;

    public TextMesh tip;

    // 事件：開始、遊戲開始時執行一次
    private void Start()
    {
        int Pnum = Random.Range(0, 10);
        cardPlayer = new Card(Pnum, -2, CardImage[Pnum]);

        int Cnum = Random.Range(0, 10);
        cardPC = new Card(Cnum, 2, CardImage[Cnum]);

        if (cardPlayer.CardNumber > cardPC.CardNumber)
        {
            tip.text = "WIN!";
        }
        else if (cardPC.CardNumber > cardPlayer.CardNumber)
        {
            tip.text = "LOSE!";
        }
        else
        {
            tip.text = "Again!";
        }
    }
}