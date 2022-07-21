using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControll : MonoBehaviour
{
    public GameObject Bullet;
    public static int HeartNum = 3;
    public GameObject Heart01;
    public GameObject Heart02;
    public GameObject Heart03;
    public GameObject canvasPrefab;

    void Update()
    {
        //�W���W
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))

        {
            this.transform.position += new Vector3(0, 0.1f, 0);
        }

        //�U���S
        if (Input.GetKey(KeyCode.DownArrow)|| Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, -0.1f, 0);
        }

        //�ť����A
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //�b��������m�ͦ�Bullet����ABullet����]�N�O�l�u����
            Instantiate(Bullet, this.transform.position, Quaternion.identity);
        }
    }

    //���a�I�����L����ɰ���
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�p�G�I�춳�A���@���R��
        if (collision.name == "cloud(Clone)")
        {
            Destroy(collision.gameObject);
            //��q-1
            HeartNum = HeartNum - 1;
            if (HeartNum == 2) //�٦�������
            {
                Heart01.SetActive(false);
            }
            else if (HeartNum == 1) //�٦��@����
            {
                Heart02.SetActive(false);
            }
            else if (HeartNum <= 0) //�S����
            {
                Heart03.SetActive(false);
                Time.timeScale = 0f;
                Instantiate(canvasPrefab, Vector2.zero, Quaternion.identity);

            }

        }

    }
}
