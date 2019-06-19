using UnityEngine;

[System.Serializable]

public class Card
{
    private int _cardnumber;
    private float _cardposistion;
    private Sprite _cardimg;

    public int CardNumber { get => _cardnumber;}
    public float CardPosistion { get => _cardposistion; set => _cardposistion = value; }
    public Sprite CardImg { get => _cardimg; }

    public Card(int argNum, float argX, Sprite argImg)
    {
        _cardnumber = argNum;
        _cardposistion = argX;
        _cardimg = argImg;
    }
}