# 들어가기 앞어서
  ![image](https://github.com/Anjinhyoung/Unity_Learning/assets/117788976/d2e4fbb0-ac6a-48f3-a7ee-349cffe089b4)
  * 유니티의 UI 시스템에서 버튼이 클릭되었을 때 실행할 함수를 지정하는 기능이다.
    
  ![image](https://github.com/Anjinhyoung/Unity_Learning/assets/117788976/c9c21cb1-6581-4a19-a456-e5ae76204915)
  * 유니티의 UI 시스템에서 사용자가 인터페이스와 상호작용할 때 발생하는 이벤트를 의미한다. ex) 슬라이더의 값이 변경될 때


```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Text _dialog;
    public Slider _slider;

    void ChangeDialog(string txt) 
    {
        _dialog.text = txt;      
            
          
    }

    
    void NowSliderValue()
    {
        Debug.Log("S_Value = " +  _slider.value);
    }
}
```
  * **using UnityEngine.UI :** 네임스페이스는 유니티의 UI 시스템과 관련된 클래스와 메서드를 포함하고 있다.
  * 이를 사용하면 유니티의 uGUI 시스템인 Canvas, Text, Button, Slider 등의 컴포넌트를 다룰 수 있다.
  * 그 결과 사용자가 임의로 만든 ChangeDialog(), NowSliderValue() 함수를 유니티 UI 시스템에서 사용할 수 있다.

![image](https://github.com/Anjinhyoung/Unity_Learning/assets/117788976/a1039011-fae5-4fcd-a6bd-9b3e689cdac8)
