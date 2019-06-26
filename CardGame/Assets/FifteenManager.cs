using UnityEngine;
using UnityEngine.SceneManagement;

public class FifteenManager : MonoBehaviour
{
    private Card[] cardPlayer = new Card[2], cardPC= new Card[2];

    public Sprite[] images;

    public TextMesh tipMiddle, tipBottom;

    private void Start()
    {
        Deal(0, 8);
    }


    private void Update()
    {
        if (cardPlayer != null && cardPlayer[1] == null)
        {
            tipBottom.text = "        請按 空白鍵 發牌";

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Deal(1, 4);
                Check();
            }
        }
        if (tipBottom.text == "請按 R 重新發牌 或按 ESC 離開" && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("15點");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    private void Deal(int cardIndex, float cardPosition)
    {
        int rPlayer = Random.Range(0, 10);
        cardPlayer[cardIndex] = new Card(rPlayer, -cardPosition, images[rPlayer]);

        int rPC = Random.Range(0, 10);
        cardPC[cardIndex] = new Card(rPC, cardPosition, images[rPC]);
    }

    private void Check()
    {
        int totalPlayer = cardPlayer[0].CardNumber + cardPlayer[1].CardNumber;
        int totalPC = cardPC[0].CardNumber + cardPC[1].CardNumber;

        /*/Debug.Log("player sum is:" + totalPlayer);
        Debug.Log("pc sum is:" + totalPC);/*/

        if (totalPlayer > 15 && totalPC > 15)
        {
            tipMiddle.text = "平手";
        }
        else if (totalPlayer > 15 && totalPC <= 15)
        {
            tipMiddle.text = "失敗";
        }
        else if (totalPlayer <= 15 && totalPC > 15)
        {
            tipMiddle.text = "獲勝";
        }
        else if (totalPlayer > totalPC)
        {
            tipMiddle.text = "獲勝";
        }
        else if (totalPlayer < totalPC)
        {
            tipMiddle.text = "失敗";
        }
        else
        {
            tipMiddle.text = "平手";
        }
        tipBottom.text = "請按 R 重新發牌 或按 ESC 離開";
    }
}






#region 龍寫的
/*/using UnityEngine;
using UnityEngine.SceneManagement;

public class FifteenManager : MonoBehaviour
{
    public Card[] PokerPlayer = new Card[2];
    public Card[] PokerCOM = new Card[2];
    public Sprite[] CardImage;
    public TextMesh tip;

    private void MakeCard(Card card, int x, int num)
    {
        if (num <= 10)
            card = new Card(num, x, CardImage[num - 1]);
        else
            card = new Card(10, x, CardImage[num - 1]);
    }

    private void Start()
    {
        MakeCard(PokerPlayer[0], -2, Random.Range(1, 13));
        MakeCard(PokerPlayer[1], -5, Random.Range(1, 13));
        
        MakeCard(PokerCOM[0], 2, Random.Range(1, 13));
        MakeCard(PokerCOM[1], 5, Random.Range(1, 13));
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("15點");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}/*/
#endregion