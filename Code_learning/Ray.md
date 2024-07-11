# 들어가기 앞서서
  * Ray
    * Ray란 지정한 위치에서부터 무한대로 발사되는 가상의 선이다. 게임속에선 보이지 않지만 Debug를 통하여 Ray를 확인할 수 있다

  * RaycastHit
    * 보통 Ray를 사용한 후에 Ray에서 반환된 값을 찾기 위해서 RayCastHit을 사용하는데 Ray에 닿은 물체의 정보를 반환할 수 있다.

```C#
본 코드

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour
{

    void Update()
    {
        // 터치는 기본적으로 update에서 하는 게 좋다.
        if (Input.GetButton("Fire1"))
        {
            // Ray는 구조체로 되어 있다.
            Ray r = Camera.main.ScreenPointToRay(Input.mousePosition); // 기본적으로 main 카메라는 직접 접근이 가능하다.
            RaycastHit rHit; // out이라 초기화 할 필요가 없다.
            // 위 코드를 통해 object를 확인할 수 있다.

            // int lMask = 1 << 9; // 9번 째 비트를 켜줘

            int lMask = 1 << LayerMask.NameToLayer("Floor") | 1 << LayerMask.NameToLayer("wall");

            if (Physics.Raycast(r, out rHit, Mathf.Infinity, lMask))
            {
                Debug.Log(rHit.transform.name);
                Debug.Log(rHit.point);
            }

        }
        
    }
}
```

 * **if (Input.GetButton("Fire1"))**
   * Input.GetButton("Fire1")은 마우스 왼쪽 버튼이 눌렀는지 확인한다.
   * **Fire1**은 기본적으로 마우스 왼쪽 버튼이나 컨트롤러의 특정 버튼에 매핑되어있다.
   * 이 조건문은 마우스 왼쪽 버튼이 눌렀을 때 내부의 코드를 실행하도록 한다.

 * **Ray r = Camera.main.ScreenPointToRay(Input.mousePosition) **
   * Camera.main.ScreenPointToRay(Input.mousePosition)은 화면의 마우스 위치(Input.mousePostion)을 기준으로 카마라에서 시작되는 Ray를 생성한다.
   * 이 Ray는 카메라의 위치에서 시작하여 마우스 커서가 가리키는 방향으로 발사된다.

 *  **RaycastHit rHit**
   * RaycastHit 구조체는 Raycast가 충돌한 정보를 저장하는 데 사용한다.
   * 이 변수는 Raycast가 어떤 오브젝트와 충돌했는지 충돌 지점이 어디인지 등의 정보를 담게 된다.
     
 *  **int IMask = 1 << LayerMask.NameToLayer("Floor") | 1 << LayMask.NameToLayer("wall")**
   * LayerMask.NameToLayer("Floor")와 LayerMask.NameToLayer("wall")를 사용하여 "Floor"와 "wall" 레이어의 인덱스를 얻는다.
   * 1 << LayerMask.NameToLayer("Floor")는 해당 레이어의 비트를 켜서 레이어 마스크를 만든다.
   * | 연산자를 사용하여 두 레이어를 결합합니다. 이 레이어 마스크는 레이캐스트가 "Floor"와 "wall" 레이어에 속한 오브젝트만 감지하도록 필터링 한다.


```C#
if (Physics.Raycast(r, out rHit, Mathf.Infinity, IMask))
{
   Debug.Log(rHit.transform.name);
   Debug.Log(rHit.point);
}
```
  * Physics.Raycast(r, out rHit, Mathf.Infinity, IMask)
    * 'r': 생성된 Ray
    * 'out rHit': 충돌된 정보를 rHit 변수에 저장
    * Mathf.Infinity: 레이의 최대 거리를 무한대로 설정
    * lMask: 레이캐스트가 감지할 레이어를 지정
  
