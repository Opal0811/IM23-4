using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager_MainRole : MonoBehaviour
{
    public static string name;
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private AudioSource selectob_music;
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private GameObject bg, focus_info, focus_table, F_button, left_click, right_click;
    [SerializeField] private Animator SelectOB_anim;
    private Transform _selection;
    public static bool read_info = false;
    public static bool take_phone=false, take_candy=true;
    private Ray ray;
    // Start is called before the first frame update
    void Start()
    {
        bg.SetActive(false);
        focus_info.SetActive(false);
        SelectOB_anim.gameObject.SetActive(false);
        left_click.SetActive(false);
        right_click.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            //selectionRenderer.material = defaultMaterial;
            //_selection.gameObject.layer = LayerMask.NameToLayer("Default");
            _selection = null;  //�S��쪫�󪺮ɭԴN�|�@���Onull
        }
        try { ray = Camera.main.ScreenPointToRay(Input.mousePosition); }
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
                    //selectionRenderer.material = highlightMaterial; //��o����
                    //gb.layer = LayerMask.NameToLayer("highlight");     // �ϥ�shader��layer����
                }
                if (Input.GetMouseButtonUp(0) && ! read_info)
                {
                    if (gb.name == "���")
                    {
                        take_phone = true;
                        Destroy(gb);
                    }
                    else if(gb.name =="candy")
                    {
                        take_candy = true;
                        Destroy(gb);
                    }
                    selectob_music.Play();                  //���񭵮�
                    read_info = true;
                    focus_info.SetActive(true);
                    focus_table.SetActive(false);
                    bg.SetActive(true);
                    left_click.SetActive(false);
                    right_click.SetActive(true);
                    F_button.SetActive(false);
                    SelectOB_anim.gameObject.SetActive(true);
                }
                _selection = selection;
            }
        }
        if (Input.GetMouseButtonUp(1) && read_info)
        {
            read_info = false;
            focus_info.SetActive(false);
            focus_table.SetActive(true);
            bg.SetActive(false);
            left_click.SetActive(true);
            right_click.SetActive(false);
            F_button.SetActive(true);
            SelectOB_anim.gameObject.SetActive(false);
        }
    }
}
