using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeskInteractive2 : MonoBehaviour
{
    public GameObject focus_people, focus_table, focus_pencilbox, butt, firstperson_object, butt2;  //focus_people�����H�H����v��,focus_table��ୱ����v��,butt��button
    public GameObject focus_card, cardpic, focus_mamori, focus_flower;
    public Text butt_t, t, butt_t2, t2;   //butt_t��button����r, t��button���䪺��r
    private bool E_use = false, LookAt = false;     //�����O�_���U�FE��A�p�G���U�FE��~�i�H��F�h�X�ୱ�CLookAt�����O�_���b�ݹ]����
    private Vector3 player_pos;    //�ΨөT�w���⪺��m�A�����b�E�J��l��ö]�A���}��l��o�o�{�ۤv�ڥ����b��l����
    public GameObject[] ObjectOnDesk = new GameObject[8];  //���}�C�s��s���l�W������
    private int index = 0;        //ObjectOnDesk�����ޭ�
    private Color[] ObjectOnDesk_Color = new Color[8];   //�x�s����쥻���C��
    void Start()
    {
        focus_people.SetActive(true);
        focus_table.SetActive(false);   //�@�}�l��l��]�������۾���������
        focus_pencilbox.SetActive(false);
        cardpic.SetActive(false);
        focus_card.SetActive(false);
        focus_mamori.SetActive(false);
        focus_flower.SetActive(false);
        butt_and_text_close();          //�W�Ubutton�]������
        butt_and_text_close2();

        for (int i = 0; i < ObjectOnDesk.Length; i++)
        {
            ObjectOnDesk_Color[i] = ObjectOnDesk[i].GetComponent<Renderer>().material.color;        //���⪫�������C���x�s�_��
        }
    }
    void Update()
    {
        if (E_use == true)  //�p�G����E
        {
            firstperson_object.gameObject.transform.position = player_pos;  //����s�_�Ӫ���m������A������L�k����
            butt_t.text = "F";
            if (LookAt == false)
            {
                t.text = "���}�ୱ";
                butt_and_text_open();
            }

            Choose_PB();
            Choose_card();
            Choose_mamori();
            Choose_flower();


            if (Input.GetAxis("Mouse ScrollWheel") != 0)
            {
                index = index + (int)(Input.GetAxis("Mouse ScrollWheel") * 10);
            }

            if (LookAt == false)
            {
                if (index < 0)
                {
                    index = 0;
                }
                if (index == 0)
                {
                    ObjectOnDesk[index].GetComponent<Renderer>().material.color = Color.yellow;
                    ObjectOnDesk[1].GetComponent<Renderer>().material.color = ObjectOnDesk_Color[1];
                }

                if (index > ObjectOnDesk.Length - 1)
                {
                    index = ObjectOnDesk.Length - 1;
                }
                if (index == ObjectOnDesk.Length - 1)

                {
                    ObjectOnDesk[index].GetComponent<Renderer>().material.color = Color.yellow;
                    ObjectOnDesk[index - 1].GetComponent<Renderer>().material.color = ObjectOnDesk_Color[index - 1];
                }
                if (index > 0 && index < ObjectOnDesk.Length - 1)
                {
                    ObjectOnDesk[index].GetComponent<Renderer>().material.color = Color.yellow;
                    ObjectOnDesk[index - 1].GetComponent<Renderer>().material.color = ObjectOnDesk_Color[index - 1];
                    ObjectOnDesk[index + 1].GetComponent<Renderer>().material.color = ObjectOnDesk_Color[index + 1];
                }
            }

            if (Input.GetKeyDown(KeyCode.F) && LookAt == false)    //�S���d�ݹ]���������p��F�~�i�H���}�ୱ
            {
                index = 0;
                firstperson_object.gameObject.SetActive(true);
                Table_SwitchTo_People();
                E_use = false;
                butt_and_text_close();
                butt_and_text_close2();
                for (int i = 0; i < ObjectOnDesk.Length; i++)
                {
                    ObjectOnDesk[i].GetComponent<Renderer>().material.color = ObjectOnDesk_Color[i];
                }
            }
        }
    }
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            t.text = "�d�ݮୱ";
            butt_t.text = "E";
            butt_and_text_open();

            if (Input.GetKey(KeyCode.E) && E_use == false)    //�S���LE��~�i�H�}�Үୱ
            {
                firstperson_object.gameObject.SetActive(false); //���}�ୱ��A����N�Ȯɬݤ���
                player_pos = firstperson_object.gameObject.transform.position;  //�⨤����UE��U����m�O���_�ӡC
                butt_and_text_close();                         //��BUTTON���r����
                People_SwitchTo_Table();
                E_use = true;
                ObjectOnDesk[0].GetComponent<Renderer>().material.color = Color.yellow; //��i��ୱ���ɭԷ|�۰ʥ���]�����C
            }
        }
    }

    void OnCollisionExit(Collision other)
    {
        butt_and_text_close();
    }

    // **** �H�U�O���button�έӧO���䪺��r���}������ ****
    void butt_and_text_open()
    {
        butt.gameObject.SetActive(true);
        t.gameObject.SetActive(true);
    }
    void butt_and_text_close()
    {
        butt.gameObject.SetActive(false);
        t.gameObject.SetActive(false);
    }
    void butt_and_text_open2()
    {
        butt2.gameObject.SetActive(true);
        t2.gameObject.SetActive(true);

    }
    void butt_and_text_close2()
    {
        butt2.gameObject.SetActive(false);
        t2.gameObject.SetActive(false);
    }

    // ----------------------------------------------------

    // **** �H�U�O�۾������� ****
    void People_SwitchTo_Table()    //�N���H�H���۾������A�å��}�E�J�ୱ���۾�(�Ω�d�ݮୱ)
    {
        focus_people.SetActive(false);
        focus_table.SetActive(true);
    }

    void Table_SwitchTo_People()    //�N�E�J��l���۾������A���}�E�J�H��(�Ω����}�ୱ)
    {
        focus_people.SetActive(true);
        focus_table.SetActive(false);
    }

    void Table_SwitchTo_PB()        //�N�E�J�ୱ���۾������A���}�E�J�]����(�Ω�q�ୱ��Enter��]����)
    {
        focus_pencilbox.SetActive(true);
        focus_table.SetActive(false);
    }
    void PB_SwitchTo_Table()        //(�Ω����}�]����)
    {
        focus_pencilbox.SetActive(false);
        focus_table.SetActive(true);
    }
    void Table_SwitchTo_Card()
    {
        focus_table.SetActive(false);
        focus_card.SetActive(true);
        cardpic.SetActive(true);
    }
    void Card_SwitchTo_Table()
    {
        focus_card.SetActive(false);
        focus_table.SetActive(true);
        cardpic.SetActive(false);
    }
    void Table_SwitchTo_mamori()
    {
        focus_table.SetActive(false);
        focus_mamori.SetActive(true);
    }
    void Mamori_SwitchTo_Table()
    {
        focus_mamori.SetActive(false);
        focus_table.SetActive(true);
    }
    void Table_SwitchTo_flower()
    {
        focus_table.SetActive(false);
        focus_flower.SetActive(true);
    }
    void Flower_SwitchTo_Table()
    {
        focus_flower.SetActive(false);
        focus_table.SetActive(true);
    }

    //--------------------------------------------------------

    // **** �P��ܪ������****
    void Choose_PB()     //��]����������
    {
        if (index == 0)

        {
            if (LookAt == false)
            {
                butt_t2.text = "�ƹ�\n����";
                t2.text = "�d�ݹ]����";
                butt_and_text_open2();
            }

            if (Input.GetMouseButtonDown(0))
            {
                LookAt = true;
                ObjectOnDesk[0].GetComponent<Renderer>().material.color = ObjectOnDesk_Color[0];
                Table_SwitchTo_PB();
                butt_and_text_close();
                butt_t2.text = "�ƹ�\n�k��";
                t2.text = "���}�]����";
            }
            if (Input.GetMouseButtonDown(1) && LookAt == true)
            {
                ObjectOnDesk[0].GetComponent<Renderer>().material.color = Color.yellow;
                PB_SwitchTo_Table();
                butt_t2.text = "�ƹ�\n����";
                t2.text = "�d�ݹ]����";
                LookAt = false;
            }
        }

    }
    // ----------------------------------------------------------------

    //**** ��d��
    void Choose_card()
    {
        if (index == 2)
        {
            if (LookAt == false)
            {
                butt_t2.text = "�ƹ�\n����";
                t2.text = "�d�ݥd��";
                butt_and_text_open2();
            }
            if (Input.GetMouseButtonDown(0))
            {
                LookAt = true;
                ObjectOnDesk[2].GetComponent<Renderer>().material.color = ObjectOnDesk_Color[2];
                Table_SwitchTo_Card();
                butt_and_text_close();
                butt_t2.text = "�ƹ�\n�k��";
                t2.text = "���}�d��";
            }
            if (Input.GetMouseButtonDown(1) && LookAt == true)
            {
                ObjectOnDesk[2].GetComponent<Renderer>().material.color = Color.yellow;
                Card_SwitchTo_Table();
                butt_t2.text = "�ƹ�\n����";
                t2.text = "�d�ݥd��";
                LookAt = false;
            }
        }

    }

    //****��s�u
    void Choose_mamori()
    {
        if (index == 1)
        {
            if (LookAt == false)
            {
                butt_t2.text = "�ƹ�\n����";
                t2.text = "�d�ݱs�u";
                butt_and_text_open2();
            }


            if (Input.GetMouseButtonDown(0))
            {
                LookAt = true;
                ObjectOnDesk[1].GetComponent<Renderer>().material.color = ObjectOnDesk_Color[1];
                Table_SwitchTo_mamori();
                butt_and_text_close();
                butt_t2.text = "�ƹ�\n�k��";
                t2.text = "���}�s�u";
            }
            if (Input.GetMouseButtonDown(1) && LookAt == true)
            {
                ObjectOnDesk[1].GetComponent<Renderer>().material.color = Color.yellow;
                Mamori_SwitchTo_Table();
                butt_t2.text = "�ƹ�\n����";
                t2.text = "�d�ݱs�u";
                LookAt = false;
            }
        }
    }
    void Choose_flower()
    {
        if (index == 3)
        {
            if (LookAt == false)
            {
                butt_t2.text = "�ƹ�\n����";
                t2.text = "�d�ݤѰ�";
                butt_and_text_open2();
            }
            if (Input.GetMouseButtonDown(0))
            {
                LookAt = true;
                ObjectOnDesk[3].GetComponent<Renderer>().material.color = ObjectOnDesk_Color[3];
                Table_SwitchTo_flower();
                butt_and_text_close();
                butt_t2.text = "�ƹ�\n�k��";
                t2.text = "���}�Ѱ�";
            }
            if (Input.GetMouseButtonDown(1) && LookAt == true)
            {
                ObjectOnDesk[3].GetComponent<Renderer>().material.color = Color.yellow;
                Flower_SwitchTo_Table();
                butt_t2.text = "�ƹ�\n����";
                t2.text = "�d�ݤѰ�";
                LookAt = false;
            }
        }
    }

}