using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choose_SoundEffect : MonoBehaviour
{
    public GameObject Ob;
    public AudioSource choose_sound;
    private bool do_once=true;  //�קK���ĭ��Ƽ���
    void Update()
    {
        if(Ob.transform.position== new Vector3(-1.039f, 1.5f, -0.299f)) {   //���󭸰_�Ӫ��ɭ�(�磌��)
            if (do_once) { choose_sound.Play(); } 
            do_once = false;
        } 
        else { do_once = true; }
    }
}
