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
  * '_img'는 상자 안에 표시될 텍스처이다.  public Texture _img;에서 설정된 텍스처를 사용한다.

======================================================================================

  * **GUI.Label(new Rect(0, 0, 300, 25), "안녕하세요"); :** 'GUI.Lavel'은 텍스트를 표시하는 메서드이다.
  * "안녕하세요"는 레이블에 표시될 텍스트이다.

======================================================================================

  * **if(GUI.Button(new Rect(0, 200, 300, 25), "Click me")){} :** 'GUI.Button'은 버튼을 그리는 메서드이다. 사용자가 클릭하면 'true'를 반홚다.
  * **Debug.Log("날 눌렀어"); :** 사용자가 버튼을 클릭하면 이 코드 블록이  실행된다.

======================================================================================

```C#
void OnDrawGizmos()
{
    // Gizmos.color = Color.yellow;
    Gizmos.color = _gizmosColor;
    Gizmos.DrawSphere(transform.position, _radius);
    Gizmos.DrawLine(transform.position, transform.position + (transform.forward * 10));
}
```
 * **void OnDrawGizmos() :** 'OnDrawGizmos'는 유니티 에디터에서 기지모를 그리기 위해 사용하는 메서드이다.
 * 이 메서드는 게임 오브젝트가 선택된 상태에서 에디터 모드에서 호출된다.

=========================================================================================
 * **Gizmos.color = Color.yellow; :** 이 코드는 기즈모의 색상을 노란색으로 설정하는 코드이다.
 * 'Gizmos.color = _gizmosColor' 이 코드랑 겹쳐서 주석처리로 했다.

=========================================================================================
 * **Gizmos.color = _gizmosColor; :** _gizmosColor를 통해서 에디터에서도 기즈모의 색깔을 동적으로 설정할 수 있다.

=========================================================================================
 * **Gizmos.DrawSphere(transform.position, _radius); :** 'Gizmos.DrawSphere'은 주어진 위치에 반지름이 '_radius'인 구체를 그리는 코드다.
 * 'transform.position'은 현재 게임 오브젝트의 위치를 나타낸다. 이 위치를 중심으로 구체가 그려진다.

=========================================================================================
 * **Gizmos.DrawLine(transform.position, transform.position + (transform.forward * 10)); :** 'Gizmos.DrawLine'은 두 점을 잇는 선을 그리는 메서드이다.
 * 첫 번째 매개변수는 선의 시작점이다. 즉 현재 게임 오브젝트의 위치인 transform.position이다.
 * 두 번째 매개변수는 선의 끝점으로 transform.position에서 'transform.forward' 방향으로 10 단위 떨어진 지점이다.
   * transform.forward는 게임 오브젝트의 전방 방향으로 나타내는 벡터이다.
   * transform.position + (transform.forward * 10)은 현재 위치에서 전방으로 10 단위 떨어진 지점을 계산한다.
