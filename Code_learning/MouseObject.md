# 들어가기 앞서서 Mouse 관련 코드

```C#
void OnMouseDown()
{
  Debug.Log(gameObject.name + "눌렀어요");
}
```
  * 마우스가 해당 오브젝트를 눌렀경우 콘솔 창에 해당 오브젝트 이름 + "눌렀어요" 메세지가 나온다.


```C#
void OnMouseUp()
{
  Debug.Log(gameObject.name + "뗐어요");
}
```
  * 마우스가 해당 오브젝트를 누르고 뗄 경우 콘솔 창에 해당 오브젝트 이름 + "뗐어요" 메세지가 나온다.

```C#
void OnMouseEnter()
{
  Debug.Log(gameObject.nmae + "안으로 들어왔어요");
}
```
  * 마우스가 해당 오브젝트를 그냥 단순히 닿기만 했어도 해당 오브젝트 이름 + "안으로 들어왔어요" 메세지가 나온다.

```C#

void OnMouseExit()
{
  Debug.Log(gameObject.name + "밖으로 나갔어요");
}
```
  * 마우스가 해당 오브젝트를 닿고 단순히 나오기만 해도 해당 오브젝트 이름  + "밖으로 나갔어요" 메세지가 나온다.

  ## Instantiate 함수란?
   * 유니티에서 Instantiate 함수는 게임 오브젝트를 동적으로 생성하는데 사용하는 함수다. 이 함수를 사용하면 프로그래밍적으로 오브젝트를 생성할 수 있다. 

```C#
본 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoombScript : MonoBehaviour
{
    public int _durationHit = 3;
    public GameObject _effectBoom;
    public GameObject _effectHit;

    private void OnMouseDown() 
    {
        _durationHit--;
        GameObject go = Instantiate(_effectHit, transform.position, _effectHit.transform.rotation);
        Destroy(go, 5);
        if (_durationHit <= 0)
        {
            go = Instantiate(_effectBoom, transform.position, _effectBoom.transform.rotation);
            Destroy(go, 5);
            Destroy(gameObject);
        }
        
    }
```

```C#
public int _durationHit = 3;
public GameObject _effectBoom;
public GameObject _effectHit;
```
  * public int _durationHit = 3;
    * 객체가 몇 번 클릭될 수 있는지를 나타내는 변수입니다. 초기값은 3으로 설정되어 있다.
  * public GameObject _effectBoom;
    * 클릭 횟수가 다 소진되었을 때 생성되는 폭발 효과 객체이다.


  * public GameObject _effectHit;
    * 클릭할 때마다 생성되는 타격 효과 객체이다.

```C#
private void OnMouseDown() 
{
    _durationHit--;
    GameObject go = Instantiate(_effectHit, transform.position, _effectHit.transform.rotation);
    Destroy(go, 5);
    if (_durationHit <= 0)
    {
        go = Instantiate(_effectBoom, transform.position, _effectBoom.transform.rotation);
        Destroy(go, 5);
        Destroy(gameObject);
    }
}
```

```C#
_durationHit--;
GameObject go = Instantiate(_effectHit, transform.position, _effectHit.transform.rotation);
Destroy(go, 5);
```
  * _durationHit--;
    * 객체의 남은 클릭 횟수를 1 감소시킨다.
  * GameObject go = Instantiate(_effectHit, transform.position, _effectHit.transform.rotation);
    * _effectHit 효과 객체를 현재 객체의 위치('transform.position')와 _effectHit  객체의 회전('_effectHit.transform.rotation')으로 생성한다.
    * 생성된 객체를 go  변수에 저장한다.
  * Destory(go, 5);
    * 생성된 _effectHit 객체를 5초 후에 파괴한다.
  * if(_durationHit <= 0)
    * 객체의 남은 클릭 횟수가 0 이하인지 확인한다.
  * go = Instantiate(_effectBoom, transform.position, _effectBoom.transform.rotation);
    * _effectBoom 효과 객체를 현재 객체의 위치와 _effectBoom 객체의 회전으로 생성한다.
  * Destroy(gameObject);
    * 현재 스크립트가 부착된 객체를 파괴한다. 더 이상 존재하지 않는다.
