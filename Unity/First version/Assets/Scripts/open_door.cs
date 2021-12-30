using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class open_door : MonoBehaviour
{
    private bool open = false;
    float op = 0;
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E) && !open)
            {
                open = true;
                op = 1;
                //�q�ЫǶ}���A����ʵe   
            }
            else if (Input.GetKey(KeyCode.F) && open)
            {
                //�q���Y�����A����ʵe
                op = 0;
                open = false;
            }
            
        }
        Updateanim();
    }
    void Updateanim()
    {
        anim.SetFloat("open", op);
    }
}
