using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public CanUseCoin canUseCoinScript;
    private Transform platform; // ���Transform�R���|�[�l���g
    void OnTriggerEnter(Collider other)
    {
        // �R�C������ɏ�����ꍇ
        if (other.CompareTag("Platform"))
        {
            // ���Transform���擾
            platform = other.transform;

            // �R�C���̐e���ɐݒ�
            transform.parent = platform;
        }
        if (other.CompareTag("Point"))
        {
            ObjectSponeSpace canUseCoinScript = GameObject.FindObjectOfType<ObjectSponeSpace>();
            canUseCoinScript.Life++;
            Destroy(gameObject);
        
        }
    }
    void OnTriggerExit(Collider other)
    {
        // �R�C�����䂩�痣�ꂽ�ꍇ
        if (other.CompareTag("Platform"))
        {
            // �e�q�֌W������
            transform.parent = null;
        }
    }
}

