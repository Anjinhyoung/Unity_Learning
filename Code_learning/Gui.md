# 들어가기에 앞어서
  * **기즈모(Gizmo):** 유니티 에디터에서 장면(Scene) 보기나 게임 객체를 시각적으로 디버깅하고 편집을 위하여 사용하는 그래픽 도구다.
  * 기즈모는 게임이 실행 중이 아니어도 에디터 모드에서 표시되며, 개발자가 게임 오브젝트의 위치, 회전, 크기 등을 시각적으로 확인하고 조정할 수 있게 해준다.

```C#
Gui 예제 코드

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiTest : MonoBehaviour
{
    public Texture _img;

    public float _radius;

    public Color _gizmosColor;
     void OnGUI()
    {
        GUI.Box(new Rect(400, 0, 100, 100), _img);
        GUI.Label(new Rect(0, 0, 300, 25), "안녕하세요");
        if(GUI.Button(new Rect(0, 200, 300, 25), "Click me"))
        {
            Debug.Log("날 눌렀어");
        }
    }

     void OnDrawGizmos()
    {
        // Gizmos.color = Color.yellow;
        Gizmos.color = _gizmosColor;
    Gizmos.DrawSphere(transform.position, _radius);
        Gizmos.DrawLine(transform.position, transform.position + (transform.forward * 10));
        
    }
}
```
  * **public Texture _img; :** 'Texture' 타입의 '_img'의 이름을 가진 공용(public)변수이다. 이 변수는 유니티 에디터에서 이미지를 드래그 앤 드롭하여 할당하거나,
  * 코드에서 이미지 텍스처를 할당하는 데 사용된다.
  * **public float _radius; :** 'float'타입의 '_radius'라는 이름을 가진 공용(public)변수이다. 이 변수는 반지름 값을 저장하는 데 사용된다.
  * **public Color _gizmosColor; :** 'Color' 타입의 '_gizmosColor'라는 이름을 가진 공용 (public)변수이다. 이 변수는  기즈모(gizmo)의 색상을 저장하는 데 사용된다.


```C#
void OnGUI() 
{
    GUI.Box(new Rect(400, 0, 100, 100), _img);
    GUI.Label(new Rect(0, 0, 300, 25), "안녕하세요");
    if(GUI.Button(new Rect(0, 200, 300, 25), "Click me"))
    {
        Debug.Log("날 눌렀어");
    }
}
```
  * **void onGUI(){} :** 'onGUI()* 함수는 유니티에서 제공되는 함수로 GUI 요소를 그리는 데 사용된다. 이 메서드는 매 프레임마다 호출된다.
  * **GUI.Box(new Rect(400, 0, 100, 100), _img); :** 'GUI.Box'는 화면에 상자를 그리는 메서드이다.
  * **new Rect(400, 0, 100, 100) :** 상자의 위치와 크기를 정의한다. 여기서 Rect의 피라미터는 x좌표, y좌표, width, height 순서이다.
