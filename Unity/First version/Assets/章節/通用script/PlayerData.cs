using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public Vector3 PlayerPosition ; //����y��

    //[�q��]
    public bool Take_Cellphone , Cellphone_Unlock;
    //Take_Cellphone �O�_�������(SelectionManager_MainRole (Script))
    //Cellphone_Unlock����O�_����(PlayerPref.SetInt: "Cellphone_Unlock")�C

    //[�Ĥ@���D����l]
    public bool Take_MainRoleBook , Take_Omori , Take_Candy;
    //������SelectionManager_MainRole (Script)����

    //[�Ĥ@��������l]
    public bool Take_BrotherBook;
    //��SelectionManager_bro(Script)��take_book

    //[�ĤG�����n���~]
    public bool Take_Notebook , Take_Medicine, Take_Computer, Take_Flower , Take_Bear;
    //Selection_ob (Script)


    //[�ĤG�����n���~�ƶq]
    public int importantOb_count;

    public string Scene_Name;


}
