using UnityEngine;                               //引用 unity API
using UnityEngine.SceneManagement;

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
            tip.color = Color.yellow;
            tip.text = "WIN!";
        }
        else if (cardPC.CardNumber > cardPlayer.CardNumber)
        {
            tip.color = Color.gray;
            tip.text = "LOSE!";
        }
        else
        {
            tip.text = "Again!";
        }
       
    }

    // 更新事件：每幀執行一次，大約一秒60次
    private void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("卡片遊戲"); //場景管理 載入場景(使用場景名稱方式)
        }
    }
}