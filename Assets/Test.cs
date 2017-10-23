using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss
{
    private int hp = 100;   // 体力
    private int mp = 53;    // 魔法
    private int power = 25; // 攻撃力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    public void Magic(int damage)
    {
        // 残りmpを減らす
        if (this.mp > 5)
        {
            this.mp -= damage;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}



public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        // 要素数5の配列を初期化する
        int[] array = new int[5];
        array[0] = 100;
        array[1] = 500;
        array[2] = 1000;
        array[3] = 5000;
        array[4] = 10000;

        // 配列の要素の小さい順
        for (int cnt = 0; cnt < 5; cnt++)
        {
            Debug.Log(array[cnt]);  // 配列の要素をすべて表示する
        }


        // 配列の要素の大きい順
        for (int cnt = 4; cnt >= 0 ; cnt--)
        {
            Debug.Log(array[cnt]);  // 配列の要素をすべて表示する
        }





        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //// 攻撃用の関数を呼び出す
        //lastboss.Attack();
        //// 防御用の関数を呼び出す
        //lastboss.Defence(3);

        // 魔法用の関数を呼び出す
        for (int cnt = 0; cnt < 11; cnt++)
        {
            lastboss.Magic(5);
        }
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
