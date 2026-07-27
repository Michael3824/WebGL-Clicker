using UnityEngine;

public class ShopLogic : MonoBehaviour
{
    //クリックされたらScoreIncreaseを+1して、Scoreを-10する関数
    //※もしもScoreが10以下なら、押しても反応しない
    //Buttonから呼び出したいのでアクセス修飾子はpublicにすること
    public void AddScoreIncrease()
    {
        //もしClickDataの中のinstanceの中のScoreが10より小さいなら
        if (ClickData.instance.Score < 10)
        {
            //処理を中断する
            return;
        }
        ClickData.instance.ScoreIncrease += 1;
        ClickData.instance.Score -= 10;
    }
}
