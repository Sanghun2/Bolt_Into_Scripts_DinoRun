# [Bolt Into Scripts] 공룡런 게임 만들기

### 구글플레이 스토어 다운로드 링크
https://play.google.com/store/apps/details?id=com.NABI.DinoRunEvolution

### 강좌 링크

https://www.youtube.com/watch?v=ktm-hvm6r8s


![image](https://user-images.githubusercontent.com/50513500/151666104-d59b56bd-6745-453d-a0e8-27e078e0b806.png)


### 제작목적
* 이번 프로젝트의 목적은 스크립트가 없이 볼트로 제작된 유니티 프로젝트의 영상을 보고 스크립트를 사용해서 똑같이 구현하여 스크립트를 다루는 역량을 키우는 것 입니다.


### 간단한 플레이영상
![Dino Run Final](https://user-images.githubusercontent.com/50513500/153626666-e64447b4-3c87-4834-91ad-c5e8ed66884b.gif)


# 구현과정

### 3.장애물 만들기
![Dino Run 3](https://user-images.githubusercontent.com/50513500/152314304-e6acbdd3-7bff-4153-b713-92d237a6955c.gif)

##### 구현
* 장애물 [선인장]을 추가.
* 랜덤으로 장애물 [선인장]이 등장.
* 선인장에 부딫힐 시 Die상태로 변하며, 애니메이션과 사운드 재생.
* Die상태에서 점프 동작 및 LandSound 작동불가.

### 4.점수 구현하기
![Dino Run 4](https://user-images.githubusercontent.com/50513500/152541399-925b73fc-a666-4d0f-9d02-8d10fdd0dc8c.gif)

##### 구현
* deltaTime을 사용해 시간을 계산해서 점수로 사용.
* 점수와 텍스트 UI연결. 실시간으로 점수 표시(4자리까지 나타내고 숫자가 없는 곳은 0으로 표시)
* 10점이 될 때마다 확대효과로 포인트를 준 애니메이션을 텍스트UI에 적용.


### 5.게임 완성하기
![Dino Run 5](https://user-images.githubusercontent.com/50513500/152601910-67de068b-16fb-4857-8c4c-38436b074fe4.gif)

##### 구현
* 게임오버UI 구현
* 게임 재시작 구현
* 최고점수 갱신 기능 구현
* 점수에 따라 증가하는 속도 레벨디자인

### 6.게임 빌드하기
![Dino Run 6](https://user-images.githubusercontent.com/50513500/152820465-18c4f70e-fd3a-40b2-8308-eabb6d898fe9.gif)

##### 구현
* 조작을 화면 터치로 점프할 수 있도록 구현
* 해상도 변경(1920*1080)
* 스프라이트를 아틀라스로 묶어서 최적화
* 모바일 세팅으로 빌드

***

### :book: 추가 업데이트 (1.0.0)
* 플레이 화면과 메인화면(처음 들어갔을때 머무는 로비) 분리

##### 메인화면
* 메인화면에서 계속 달리는 애니메이션 유지하되 장애물 등장이나 점프 불가하도록 변경
* 플레이 버튼 구현
* 상점구현
* 더블점프, 업적메달 등 7가지의 여러 아이템 구현
* 시청시 동전을 얻을 수 있는 광고기능 구현
* 동전을 구매할 수 있는 인앱결제 구현
* 게임종료 버튼 구현

##### 플레이화면
* 재시작 버튼 기능 변경(플레이화면(기존 씬 1개) => 플레이화면(메인씬, 플레이씬 중 플레이씬))
* 게임오버시 홈버튼 구현
* 특정 지점에 도달할 시 점수에 따라 동전 획득 기능 구현
* 2단점프 기능 구현
* 플레이 중 특정 조건을 만족 시 업적 클리어와 함께 새로운 아이템 오픈 시스템 구현


##### 플레이영상
![Dino Run Final](https://user-images.githubusercontent.com/50513500/153781386-ed1b7fc4-5a60-433b-b202-b6107db8520d.gif)
