using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Update()
    {
        //����������

        this.transform.parent = null;

        //�C�@���l�u�V������

        this.transform.position += new Vector3(-0.1f, 0, 0);
    }
    //��l�u�I�����L����ɷ|����

    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.name == "wall4")
        {
            Destroy(this.gameObject);
        }

    }
}
