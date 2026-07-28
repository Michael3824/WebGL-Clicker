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

    public void AddGranma()
    {
        if (ClickData.instance.Score < 100)
        {
            //処理を中断する
            return;
        }
        if(ClickData.instance.GranmaBuyFlag == false)
        ClickData.instance.GranmaBuyFlag = true;

        ClickData.instance.GranmaBuycount += 1;
        ClickData.instance.Score -= 100;
    }

    //やりたいこと：30秒に1回 自動クリックが実行される
    //private float型 変数名：ElapsedTime
    private float ElapsedTIme;
    
    private void Update()
    {
        //課題：Uppdateをばあちゃんを買った後にしか動かさないようにする
        //1.ばあちゃんを買ったかどうかのフラグ
        //2.ばあちゃんを買ったかどうかのフラグ(変数)を用意
        //3.Uppdataの処理中に"もしばあちゃんを買っていれば処理を行う"というガード節を入れる
        //4.ばあちゃんを買うボタンを追加する
        //EX.ばあちゃんを買った数*スコア分 スコアを加算する
        //EX2.ばあちゃんの待機時間を変数にする

        if(ClickData.instance.GranmaBuyFlag == false)
        {
            return;
        }
        
        //deltaTime：前回のFrameからどのくらい時間が経過したか
        ElapsedTIme += Time.deltaTime;

        //もしもElapsedTimeが30秒以上だったら
        if(ElapsedTIme >= 3)
        {
            //Scoreに+1をする
            ClickData.instance.Score += 1 * ClickData.instance.GranmaBuycount;
            ElapsedTIme -= 3;
        }
    }  
}
