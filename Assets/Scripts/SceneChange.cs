using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Scene 관리를 위한 namespace

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // SceneManager.LoadScene("TestScenes"); // Scene 이름을 그대로 해야 한다.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI() // 유니티에서 제공하는 함수
    {
        if (GUI.Button(new Rect(0, 0, 200, 40), "TestScene Load!"))
        {
            SceneManager.LoadScene("TestScenes");
        }
    }
}
