using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public CanUseCoin canUseCoinScript;
    private Transform platform; // 台のTransformコンポーネント
    void OnTriggerEnter(Collider other)
    {
        // コインが台に乗った場合
        if (other.CompareTag("Platform"))
        {
            // 台のTransformを取得
            platform = other.transform;

            // コインの親を台に設定
            transform.parent = platform;
        }
        if (other.CompareTag("Point"))
        {
            SpawnObjectinspace canUseCoinScript = GameObject.FindObjectOfType<SpawnObjectinspace>();
            canUseCoinScript.Life++;
            Destroy(gameObject);
        
        }
    }
    void OnTriggerExit(Collider other)
    {
        // コインが台から離れた場合
        if (other.CompareTag("Platform"))
        {
            // 親子関係を解除
            transform.parent = null;
        }
    }
}

