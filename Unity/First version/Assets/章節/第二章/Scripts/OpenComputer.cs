using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenComputer : MonoBehaviour
{
    [SerializeField] private GameObject camera_computer, camera_peo, walk_run_music;
    private bool open = false, trigger = false, ClickGameButton = false;
    [SerializeField] private GameObject E_image, Text_OpenComputer, Text_CloseComputer;
    private void Awake()
    {
        E_image.SetActive(open);
        Text_OpenComputer.SetActive(open);
        Text_CloseComputer.SetActive(open);
    }

    private void Update()
    {
        Debug.Log($"Open:{open} , ClickGameButton:{ClickGameButton}");
        if (Input.GetKeyDown(KeyCode.E) && trigger && !ClickGameButton)
        {
            open = !open;
            camera_computer.SetActive(open);
            camera_peo.SetActive(!open);

            if (open)
            {
                GameObject.Find("�D��").GetComponent<controlpeople>().enabled = false;
            }
            else
            {
                GameObject.Find("�D��").GetComponent<controlpeople>().enabled = true;
            }
        }

    }
    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            trigger = true;
            if (!open && !ClickGameButton)  //�٨S���}�q���]�S�}�C��
            {
                E_image.SetActive(true);
                Text_OpenComputer.SetActive(true);
                Text_CloseComputer.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                GameObject.Find("�D��").GetComponent<controlpeople>().enabled = true;
                walk_run_music.SetActive(true);
            }
            else if (open && !ClickGameButton)  //�w�g���}�q���B�S�����}�C��
            {
                E_image.SetActive(true);
                Text_OpenComputer.SetActive(false);
                Text_CloseComputer.SetActive(true);
                Cursor.lockState = CursorLockMode.Confined;
                GameObject.Find("�D��").GetComponent<controlpeople>().enabled = false;
                walk_run_music.SetActive(false);

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        E_image.SetActive(false);
        Text_OpenComputer.SetActive(false);
        Text_CloseComputer.SetActive(false);
        trigger = false;
    }

    public void ClickGame() //���i��O���}�C���άO�����C��
    {
        ClickGameButton = !ClickGameButton;
        ClickGameButtonAndCannotShow_EImage();
    }

    private void ClickGameButtonAndCannotShow_EImage()  //�p�G�O���}�C�����ɭԴN�����UI
    {
        if (ClickGameButton)
        {
            E_image.SetActive(false);
            Text_OpenComputer.SetActive(false);
            Text_CloseComputer.SetActive(false);
        }
    }
}
