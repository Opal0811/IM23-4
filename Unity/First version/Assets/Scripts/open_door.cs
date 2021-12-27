using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class open_door : MonoBehaviour
{
    public Text b1_t,t1;
    public GameObject b1;
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
            if (!open)
            {
                b1.SetActive(true);
                t1.gameObject.SetActive(true);
                b1_t.text = "E";
                t1.text = "���}��";
            }
            else
            {
                b1.SetActive(true);
                t1.gameObject.SetActive(true);
                b1_t.text = "F";
                t1.text = "���W��";
            }
   
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
    private void OnTriggerExit(Collider other)
    {
        b1.SetActive(false);
        t1.gameObject.SetActive(false);
    }
    void Updateanim()
    {
        anim.SetFloat("open", op);
    }
}
