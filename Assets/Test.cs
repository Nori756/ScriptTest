using UnityEngine;
using System.Collections;
public class Boss {
    public int mp = 53; //マジックポイント



    public void Majic() {
        Debug.Log("魔法攻撃をした。残りMPは〇〇。");

        this.mp -= 5;
    }
}
    public class Test : MonoBehaviour {
        // Use this for initialization
        void Start()  {
            // 配列を初期化する
            int[] array = { 10, 90, 100, 20, 70, 80, 30, 120 };

            // 配列の要素数のぶんだけ処理を繰り返す
            for (int i = 0; i < array.Length; i++)
            {

                // 配列の要素を表示する
                Debug.Log(array[i]);
            }

            for (int k = array.Length - 1; 0 <= k; k--)
            {

                Debug.Log(array[k]);
            }

            // Bossクラスの変数を宣言してインスタンスを代入
            Boss lastboss = new Boss();

            if (lastboss.mp < 5)
            {
                // mpが５以下だった場合
                Debug.Log("MPが足りないため魔法が使えない");
            }
            else
            {
                // mpが5以上だった場合

                // 魔法用の関数を呼び出す
                lastboss.Majic();




            }
        }
    


    // Update is called once per frame
    void Update()
    {

    }
}