using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class choose_SoundEffect : MonoBehaviour
{
    [SerializeField] private GameObject Ob;
    [SerializeField] private AudioSource choose_sound;
    [SerializeField] private bool do_once=true;  //�קK���ĭ��Ƽ���
    void Update()
    {
        if(Ob.transform.position== new Vector3(-0.445f, 3.979f, 23.568f)) {   //���󭸰_�Ӫ��ɭ�(�磌��)
            Debug.Log("�b");
            if (do_once) { choose_sound.Play(); } 
            do_once = false;
        } 
        else { do_once = true; }
    }
}
