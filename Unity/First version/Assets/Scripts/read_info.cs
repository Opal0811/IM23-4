using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class read_info : MonoBehaviour
{
    [SerializeField] private GameObject paper1, paper2, paper3, paper4, paper5, card,bg;
    [SerializeField] private Text info;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
        if (SelectionManager.name == "�K���Ȳ�1�Ӥ��e")
        {
            paper1.SetActive(true);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(false);
            card.SetActive(false);
        }
        else if (SelectionManager.name == "�K���Ȳ�2�Ӥ��e")
        {
            info.gameObject.SetActive(true);
            info.text = "�Ĥ@���Pı�즺�`��Ө���� \n�O�o�n�b����ּ֬���... \n\t\t\t\t\t\t\t�j�_";
            paper1.SetActive(false);
            paper2.SetActive(true);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(false);
            card.SetActive(false);
        }
        else if (SelectionManager.name == "�K���Ȳ�3�Ӥ��e")
        {
            info.gameObject.SetActive(true);
            info.text = "���b�A�@�����n�C   \n\t\t\t\t\t\t\t�N�[";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(true);
            paper4.SetActive(false);
            paper5.SetActive(false);
            card.SetActive(false);
        }
        else if (SelectionManager.name == "�K���Ȳ�4�Ӥ��e")
        {
            info.gameObject.SetActive(true);
            info.text = "�]�����A�A�ڤ~���H��Ū�쨺���j��\n�ڳ�������F�O�A���ܤF�ڡC\n�A��j�a������n�����򦺯��n��W�A...   \n\t\t\t\t\t\t\t�t��";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(true);
            paper5.SetActive(false);
            card.SetActive(false);
        }
        else if (SelectionManager.name == "�K���Ȳ�5�Ӥ��e")
        {
            info.gameObject.SetActive(true);
            info.text = "�u�W���`�O��̵��}���H�a���A�A�n�ּ֡v\n�u�ڭ̦n�Q�A�v\n�u�A�n�b����L�o�}�ߡv\n�u���§A�v\n�u�A�������}�F�v";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(true);
            card.SetActive(false);

        }
        else if (SelectionManager.name == "�d��")
        {
            info.gameObject.SetActive(true);
            info.text = "���b�A �藍�_...\n�A�|�b���̹�{�A���ڷQ��\n�U���l�ڭ��٭n��ܦn���B��";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(false);
            card.SetActive(true);
        }
    }
}
