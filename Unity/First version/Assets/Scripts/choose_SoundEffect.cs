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
        if(Ob.transform.position== new Vector3(-0.484f, 1.35f, -0.853f)) {   //���󭸰_�Ӫ��ɭ�(�磌��)
            if (do_once) { choose_sound.Play(); } 
            do_once = false;
        } 
        else { do_once = true; }
    }
}
