using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class Selection_ob : MonoBehaviour
{
    public static string name;
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private AudioSource selectob_music;
    private Transform _selection;
    private Ray ray;
    
    /// <summary>
    /// list�̭��N��:
    /// [0] ��O��
    /// [1] �ĳU
    /// [2] ���q
    /// [3] �Ѱ�
    /// [4] �p������
    /// 
    /// �ȥN��:
    /// 0�N��S�I�L
    /// 1�N���I�L
    /// </summary>
    private List<int> important_ob = new List<int> { 0, 0, 0, 0, 0};
    public int ob_count = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            _selection = null;  //�S��쪫�󪺮ɭԴN�|�@���Onull
        }
        try { ray = Camera.main.ScreenPointToRay(Input.mousePosition); }    //�u��tag�OMainCamera���ۮg�u
        catch
        {
            //do nothing�A���n������ĵ�i�N�n
        }
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))   //���I����|�^��true,�S���hfalse
        {
            var selection = hit.transform;      //��g�u���g������
            var selectionRenderer = selection.GetComponent<Renderer>(); //��Q���g�����骺render
            var gb = selection.gameObject;
            if (selection.CompareTag(selectableTag))
            {
                if (selectionRenderer != null)
                {
                    name = gb.name;
                    if (Input.GetMouseButtonUp(0))
                    {
                        Debug.Log(name);
                        if (name == "�ĳU")
                        {
                            important_ob[1] = 1;
                            ob_count++;
                        }                        
                        else if (name == "�p��")
                        {
                            important_ob[4] = 1;
                            ob_count++;
                        }
                        
                        selectob_music.Play();                  //���񭵮�
                    }
                }
                _selection = selection;
            }

        }
        /*
        if (Input.GetMouseButton(1) && read_info)
        {
            read_info = false;
        }
        */
    }
}
