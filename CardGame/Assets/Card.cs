using UnityEngine;

[System.Serializable]   //類別序列化：顯示於屬性面板

public class Card
{
    //封裝:不顯示
    private int _cardnumber;
    private float _cardposistion;
    private Sprite _cardimg;

    //屬性：不顯示
    public int CardNumber { get => _cardnumber;}
    public float CardPosistion { get => _cardposistion; set => _cardposistion = value; }
    public Sprite CardImg { get => _cardimg; }

    public Card(int argNum, float argX, Sprite argImg)
    {
        _cardnumber = argNum;
        _cardposistion = argX;
        _cardimg = argImg;

        //時常在UNITY作的幾件事情 1.生成 2.取得位子 3.給視覺素材
        GameObject card = new GameObject("卡片"); //unity api 新增遊戲物件(名稱)
        card.AddComponent<SpriteRenderer>();     // 添加元件 泛型方法 <類型>

        // 卡片 取得元件 圖片 = 屬性 . 圖片
        card.GetComponent<SpriteRenderer>().sprite = CardImg;

        // 卡片 取得元件 變形 座標 = 新二為向量(X, Y)
        card.GetComponent<Transform>().position = new Vector2(CardPosistion, 0);
    }
}