using UnityEngine;

public class FifteenManager : MonoBehaviour
{
    public Card PokerPlayer, PokerCOM;
    public Sprite[] CardImage;
    public TextMesh tip;

    private void Start()
    {
        int Pnum1 = Random.Range(0, 16);
        PokerPlayer = new Card(Pnum1, -2, CardImage[Pnum1]);
    }
}
