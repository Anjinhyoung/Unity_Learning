using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Scene ������ ���� namespace

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // SceneManager.LoadScene("TestScenes"); // Scene �̸��� �״�� �ؾ� �Ѵ�.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI() // ����Ƽ���� �����ϴ� �Լ�
    {
        if (GUI.Button(new Rect(0, 0, 200, 40), "TestScene Load!"))
        {
            SceneManager.LoadScene("TestScenes");
        }
    }
}
