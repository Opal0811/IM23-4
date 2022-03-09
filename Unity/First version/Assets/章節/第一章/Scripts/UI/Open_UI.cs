//��
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_UI : MonoBehaviour
{
    [SerializeField] private Animator MainMenu;
    public bool open = false,Open_SM=false;
    //Open_SM�����}�]�w�P���U���

    public void QuitGame()
    {
        Application.Quit();
    }
    public void ContinueGame()
    {
        open = false;
        MainMenu.SetTrigger("FlyOut");
        Cursor.lockState = CursorLockMode.Locked;
        GameObject.Find("Camera-��H��").GetComponent<followpeople>().enabled = true;
        GameObject.Find("FirstPerson").GetComponent<controlpeople>().enabled = true;
        
    }
    public void Open_SettingMenu()
    {
        Open_SM = !Open_SM;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            open = !open;
            if (open && !Open_SM)
            {
                MainMenu.SetTrigger("FlyIn");
                GameObject.Find("Camera-��H��").GetComponent<followpeople>().enabled = false;
                GameObject.Find("FirstPerson").GetComponent<controlpeople>().enabled = false;
                Cursor.lockState = CursorLockMode.Confined;
            }
            else if (!open && !Open_SM)
            {
                ContinueGame();
            }
        }
    }
}
