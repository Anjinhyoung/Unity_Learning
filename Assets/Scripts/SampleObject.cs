using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Transform // class 형태
        // transform // 객체 형태 
        // GameObject
        // gameObject
        // 위에 4가지는 직접 접근하게 만들었다.

        //transform.position = new Vector3(1, 1, 1); // 위치를 바꾼다.(직접 접근)
        //Camera cam = GetComponent<Camera>(); // 참조 형식
        //cam.enabled = false;

        GameObject go = GameObject.Find("Directional Light");
        Light dLight = go.GetComponent<Light>();

        dLight.enabled = false; // 순수히 '빛'만 사라지게
        dLight.gameObject.SetActive(false); // 게임 오브젝트가 없어진다.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
