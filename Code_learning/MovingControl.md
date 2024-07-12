# 오일러 각
  * 게임 오브젝트의 회전을 위해 인스펙터에 표시되는 X, Y, Z 값

# Quaternion
  * 유니티의 Quaternion(쿼터니언) 클래스는 게임 오브젝트의 3차원 방향을 저장하고, 이를 통해 한 방향에서 다른 방향으로의 상대 회전을 설명한다.
  * 1. Quternion.LookRotation(Vector3 forward): 주어진 forward 방향으로 바라보는 회전하고 쿼터니언 값을 반환한다.
  * 2. Quternion.LookRotation(Vector3 forward, Vector3 upwards): 주어진 forward 방향으로 회전시키고, 명시적으로 지정된 upwards 방향을
    사용, 이 함수는 객체의 회전을 더 정확하게 제어 할 수 있게 해준다.

# transform.LookAt()
  * transform.LookAt(Transform target): 현재 객체를 'target' 객체의 위치를 바라보도록 회전시킨다.
  * transform.LookAt(Vector3 worldPosition): 현재 객체를 'worldPosition' 위치를 바라보도록 회전시킨다.
  * transform.LookAt(Vector3 worldPosition, Vector3 worldUp): 현재 객체를 worldPosition 위치를 바라보도록 회전시키고, worldup 벡터 위쪽 방향으로 사용한다.

# Magnitude
 * 벡터의 크기(또는 길이)는 벡터의 시작점에서 끝점까지의 길이
 * 수식은 아래와 같다.
 * ![image](https://github.com/user-attachments/assets/f07b13cf-bfac-41d6-9b99-986226a88076)
 * 출처: Chat GPT
 * Magnitude의 사용법(Magnitude는 **읽기 전용 속성**이라서 'get'만 제공된다.)

```C#
Magnitude 사용법

Vector3 vector = new Vector3(3,4,0);
float magnitude = vector.magnitude;
Debug.Log("Magnitude: " + magnitude);

출력 결과
5
```
 * 사용하는 이유: 거리 계산, 정규화, 물리 계산 등등

# 정규화
 * 주어진 벡터의 길이를 1로 만드는 과정 이렇게 만들어진 벡터를 **단위 벡터**라고 한다.
 * 정규화는 벡터의 방향은 유지하면서 크기만을 조정하는 작업이다.
 * 정규화 사용방법들

```C#
정규화 사용방법 - 1(.normalized)

Vector3 vector = new Vector3(3,4,0);
Vector3 normalizedVector = vector.normalized; // 정규화된 벡터 반환
```

```C#
정규화 사용방법 -2(.Normalize())

Vector3 vector = new Vector3(3,4,0);
vector.Normalize(); // 원본 벡터를 정규화
```
 
    
