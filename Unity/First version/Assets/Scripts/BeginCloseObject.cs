using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginCloseObject : MonoBehaviour
{
    private GameObject changeScene;

    private void Start()
    {
        changeScene = GameObject.Find("��������");
        changeScene.SetActive(false);
    }
}
