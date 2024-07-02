# 유니티 기본 코드

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour 
{

    // Start is called before the first frame update
    void Start() 
    {

    }

    // Update is called once per frame
    void Update() 
    {

    }
}
```
  * 유니티에서 처음 script를 만들면 제공되는 기본 템플릿 코드이다.
  * 하나씩 살펴 보자

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
```
  * Unity에서 기본적으로 사용하는 네임스페이스들이다.
  * **UnityEngine**은 Unity의 핵심 기능들을 제공하는 네임스페이스이다.

```C#
public class NewBehaviourScript : MonoBehaviour
```
  * NewBehaviourScript라는 클래스를 정의하며, 이 클래스는 MonoBehaviour를 상속받는다.
  * MonoBehaviour는 Unity에서 스크립트가 특정 게임 오브젝트에 부착되어 동작할 수 있도록 하는 기본 클래스이다.

```C#
void Start()
```
  * 이 메서드는 스크립트가 활성화될 때 처음 한 번 호출된다. 일반적으로 초기화 작업을 수행하는 데 사용된다.

```c#
void Update()
```
  * 이 메서드는 매 프레임마다 한 번씩 호출된다.
  * 주로 게임 로직이나 애니메이션 업데이트, 사용자 입력 처리 등을 이 메서드에서 수행한다.

# Debug.Log();
  * Debug.Log()는 디버깅 도구로, 유니티 개발 중에 특정 메세지를 콘솔창에 출력하는 기능이다.
```C#
Start()함수에 Debug.Log()를 넣었을 경우

using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("안녕하세요");  // 게임이 시작될 때 "안녕하세요" 메시지가 콘솔에 출력된다.
    }
}
```

```C#
Updata() 함수에 Debug.Log()를 넣었을 경우

using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    void Update()
    {
        Debug.Log("안녕하세요");  // 매 프레임마다 "안녕하세요" 메시지가 콘솔에 출력된다.
    }
}
