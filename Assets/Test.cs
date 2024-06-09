using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // 配列を初期化
        int[] array = { 1, 2, 3, 4, 5 };

        //　配列の要素を順番に表示する
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //　配列の要素を逆順で表示する
        for (int i = array.Length -1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
