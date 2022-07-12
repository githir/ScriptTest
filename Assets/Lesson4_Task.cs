using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Lesson4 Chapret9.5 課題：配列を宣言して出力しよう
public class Lesson4_Task : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

        Debug.Log("\n");
        Debug.Log("＞「課題」開始");
        
        // 要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化する
        Debug.Log("＞要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化する");
        int[] points = { 11, 22, 33, 44, 55 };
        Debug.Log("int[] points = { 11, 22, 33, 44, 55 };");
        // for文を使い、配列の各要素の値を順番に表示する
        Debug.Log("＞for文を使い、配列の各要素の値を順番に表示する");
        for (int i = 0; i < points.Length; i++)
        {
            Debug.Log(points[i]);
        }
        // for文を使い、配列の各要素の値を逆順に表示する
        Debug.Log("＞for文を使い、配列の各要素の値を逆順に表示する");
        for (int i = points.Length; i > 0; i--)
        {
            Debug.Log(points[i - 1]);
        }
        Debug.Log("＞「課題」終了");
        Debug.Log("\n");
    }
    // Update is called once per frame
    void Update()
    {
    }
}