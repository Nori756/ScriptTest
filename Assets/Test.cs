using UnityEngine;
using System.Collections;
public class Boss
{
    // int型の変数mpを宣言し、53で初期化してください
    public int mp = 53; //マジックポイント


    // mpを消費して魔法攻撃をするMagic関数を作ってください
    public void Majic()
    {
        // Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください

        // 足りる場合は　Magic関数内でmpを5減らしてから残りMPを表示「魔法攻撃をした。残りMPは〇〇（のこっているMP）。」
        // 足りない場合は「MPが足りないため魔法が使えない。」と表示

        if (this.mp < 5)
        {
            // mpが５以下だった場合
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        else
        {
            // mpが5以上だった場合
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp+"。");
        }
    }
}
public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        // 配列を初期化する
        int[] array = { 10, 90, 100, 20, 70, 80, 30, 120 };

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = 0; i < array.Length; i++)
        {

            // 配列の要素を表示する
            Debug.Log(array[i]); // ８回呼びだされている。
        }

        for (int k = array.Length - 1; 0 <= k; k--)
        {

            Debug.Log(array[k]);
        }

        // Start関数で下記の条件を満たしてください
        // Magic関数を呼び出して、魔法を使ってください
        // Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示されることを確認してください

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        for (int i = 0; i < 11; i++)
        {
            lastboss.Majic();
        }
    }



    // Update is called once per frame
    void Update()
    {

    }
}