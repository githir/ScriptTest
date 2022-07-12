﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;   // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;    // 魔力

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

    // 魔法攻撃用の関数
    public void Magic()
    {
        if (this.mp > 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }

}

public class Lesson4_Task_Ext : MonoBehaviour
{

    void Start()
    {

        Debug.Log("\n");
        Debug.Log("＞「発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出そう」開始");

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();
        Boss midboss = new Boss();

        /*
        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        // 攻撃用の関数を呼び出す
        midboss.Attack();
        // 防御用の関数を呼び出す
        midboss.Defence(2);
        */

        // 魔法攻撃用の関数を呼び出す
        for (int i = 1; i < 13  ; i++)
        {
            Debug.Log("＞魔法攻撃" + i + "回目");
            lastboss.Magic();
        }

        Debug.Log("＞「発展課題」終了");
        Debug.Log("\n");
    }

    // Update is called once per frame
    void Update()
    {

    }
}