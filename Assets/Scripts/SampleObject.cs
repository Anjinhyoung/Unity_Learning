using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Transform // class ����
        // transform // ��ü ���� 
        // GameObject
        // gameObject
        // ���� 4������ ���� �����ϰ� �������.

        //transform.position = new Vector3(1, 1, 1); // ��ġ�� �ٲ۴�.(���� ����)
        //Camera cam = GetComponent<Camera>(); // ���� ����
        //cam.enabled = false;

        GameObject go = GameObject.Find("Directional Light");
        Light dLight = go.GetComponent<Light>();

        dLight.enabled = false; // ������ '��'�� �������
        dLight.gameObject.SetActive(false); // ���� ������Ʈ�� ��������.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
