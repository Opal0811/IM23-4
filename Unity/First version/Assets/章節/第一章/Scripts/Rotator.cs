using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;
    bool dragging = false;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnMouseDrag()
    {
        dragging = true;
    }
    private void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))  //���U�ƹ������n��}��
        {
            dragging = false;
        }
    }

    private void FixedUpdate()
    {
        if (dragging)
        {
            float x = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            float y = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
            if (rb.gameObject.name == "�d��")
            {
                rb.transform.Rotate(0, 0, -x);
            }
            else if ( rb.gameObject.name == "�K���Ȳ�2�Ӥ��e" || rb.gameObject.name == "�K���Ȳ�4�Ӥ��e" || rb.gameObject.name == "�K���Ȳ�5�Ӥ��e" )
            {
                rb.transform.Rotate(0,-x,0);
            }
            else if(rb.gameObject.name == "�K���Ȳ�3�Ӥ��e")
            {
                rb.transform.Rotate(-x,0, 0);
            }
            else if(rb.gameObject.name == "�s�u" || rb.gameObject.name == "��~")
            {
                rb.transform.Rotate(0, 0, x);
            }
        }
    }
}
