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

            // Debug.Log("마우스 좌클릭 했어요");
        }
        
    }
}
```
