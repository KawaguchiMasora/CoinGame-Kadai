using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class End : MonoBehaviour
{
    public TMP_Text EndUi;

    private void Start()
    {
        EndUi.enabled = false;
    }
    private void Update()
    {
        ObjectSponeSpace canUseCoinScript = GameObject.FindObjectOfType<ObjectSponeSpace>();
        Debug.Log(canUseCoinScript.Life);
         if (canUseCoinScript.Life == 0)
         {
            EndUi.enabled = true;
            Debug.Log("hahahahahah");
         }

    }
}
