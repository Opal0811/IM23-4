using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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

        //�p�G�I�쥪������A�R���l�u

        if (collision.name == "wall1")

            Destroy(this.gameObject);

    }
}
