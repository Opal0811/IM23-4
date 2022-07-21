using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //���V��
        this.transform.position += new Vector3(0.1f,0 , 0);
        if(PlaneControll.HeartNum == 0)
        {
            Destroy(this.gameObject);
        }
    }

    //�I��F��
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�Q�l�u����
        if(collision.name == "Bullet(Clone)")
        {
            Score.score = Score.score + 1;
            CloudDisappear();
        }
        //�I�쥪�����
        else if (collision.name == "wall2")
        {
            //������
            Destroy(this.gameObject);
        }
    }

    //������
    public void CloudDisappear()
    {
        //������
        Destroy(this.gameObject);
    }
}
