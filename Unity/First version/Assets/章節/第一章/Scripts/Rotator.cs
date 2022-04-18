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
            if (rb.gameObject.name == "�d��" || rb.gameObject.name == "candy")
            {
                rb.transform.Rotate(0, 0, -x);
            }
            else if (rb.gameObject.name == "�K����1" || rb.gameObject.name == "�K����2" || rb.gameObject.name == "�K����4" || rb.gameObject.name == "�K����3" || rb.gameObject.name == "�K����5")
            {
                rb.transform.Rotate(-x,0,0);
            }
            else if( rb.gameObject.name == "�K����6" || rb.gameObject.name == "�K����7" )
            {
                rb.transform.Rotate(0,-x, 0);
            }
            else if(rb.gameObject.name == "�s�u" || rb.gameObject.name == "��~" || rb.gameObject.name == "���" )
            {
                rb.transform.Rotate(0, 0, x);
            }
            else if (rb.gameObject.name == "�ƾ�")
            {
                rb.transform.Rotate(0, x, 0);
            }
        }
    }
}
