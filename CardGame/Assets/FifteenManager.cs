using UnityEngine;
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
}
