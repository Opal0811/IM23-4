using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class chagne_Scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitfor2sec());
    }

    IEnumerator waitfor2sec()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("�s�ʵe");
    }
}
