using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour // 유니티 기능들을 사용하기 위한 상속
    // 최초의 이름명으로 정해진다.
{

    int num = 5;
    // 만약에 public int num이였으면 유니티 에디터에서도 바꿀 수 있다.
    // Start is called before the first frame update
    void Start() // 오브젝트에 붙어 있을 때 실행이 한 번만
    {
        int number = 10;
        Debug.Log(number);
        number = 100;
        Debug.Log(num);
        num = 20; // 여기서 바뀐 게 적용이 된다. (처음 알았네)
    }

    // Update is called once per frame
    void Update() // 오브젝트에 붙어 있을 때 실행이 무한
    {
        // Debug.Log("안녕");
        Debug.Log(num);
    }
}
