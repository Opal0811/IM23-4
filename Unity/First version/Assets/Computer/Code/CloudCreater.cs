using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCreater : MonoBehaviour
{
    public GameObject cloud;
    // Start is called before the first frame update
    void Start()
    {
        //�C�����@���y���{��
        InvokeRepeating("CreatCloud", 1, 1);
    }

    public void CreatCloud()
    {
        int CloudNum;
        //�H���X����(0-2��)
        CloudNum = Random.Range(0, 3);

        //�}�l�ͦ�
        for(int i = 0 ; i < CloudNum ; i++)
        {
            //�ŧi�ͦ�Y�y�СA�]�w�H��13��83��
            float y;
            y = Random.Range(13, 83);
            Instantiate(cloud, new Vector3(-9, y, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("GameController").transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
