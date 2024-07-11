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
