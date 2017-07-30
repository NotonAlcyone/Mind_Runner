# Game A Week
**1주 1겜** 만들기 프로젝트

## 제작자 한마디

**게임을 만드는 사람이 게임 개발자라면, 저도 제대로 된 걸음을 걷기 시작하는 겁니다.**

---

## Mind_Runner
![gameplay](https://user-images.githubusercontent.com/15938440/28751300-1a2fe204-753f-11e7-820f-5b41e5568160.png)
### 게임 소개
끝없이 나오는 적을 점프로 피하는 플랫폼 게임입니다.

### 주요 구현 기능

#### 다단 점프
![airjumpinspector](https://user-images.githubusercontent.com/15938440/28751293-08992adc-753f-11e7-9ad1-16962482fb47.png)

Inspector에 입력된 횟수만큼 다단점프가 가능합니다.

#### 무한 반복형 배경
![bginspector](https://user-images.githubusercontent.com/15938440/28751297-1773297c-753f-11e7-90b9-a363632b178f.png)

원하는 만큼의 배경을 각각 원하는 속도로 무한 반복 할 수 있습니다.  


#### 적 기록 시스템
![dict2](https://user-images.githubusercontent.com/15938440/28751299-192aea84-753f-11e7-954e-23fd3c22fe7c.png)
![dict](https://user-images.githubusercontent.com/15938440/28751305-40f8e44e-753f-11e7-8c73-678aee5386af.png)

한번 사망하면, 플레이어를 사망시킨 적에 대한 정보를 볼 수 있습니다.

#### 스킬 사용시 컷신

Time.timescale을 이용하여 Bullet time과 비슷한 컷신을 구현했습니다


### 아쉬운 점

###### Inspector 이야기

Find 같은 함수가 불편하여  public 선언을 남발하여 Inspector에 너무 많이 의존 했다고 생각합니다.

###### 패턴형 적 이야기

적의 출현을 순수랜덤에만 의지하지 않고, 플레이어가 많이 죽은 적일수록 등장 빈도가 높아지게 하려 했으나, 일정문제로 실패하였습니다.

### 개발 후 깨달은 점

###### 일정관리

어쩌면 당연한 이야기일지도 모르지만, 주중에서의 게으름은 주말의 피곤함을 불러옵니다.

###### 피드백과 퀼리티

게임의 피드백을 받고자 하였으나, 제작된 게임의 퀼리티가 높지 않아 피드백을 요청하는것 조차 부끄러운 면이 있었습니다.   
좋은 수준의 피드백을 받기위해선, 그에 상응하는 퀼리티가 필요합니다.~~아니면 철면피~~

###### 아트작업

아트 리소스의 작업을 스스로 하는것은 큰 만족감을 불러오지만,  1인개발에 있어서는 좋은 선택이 아니라고 생각됩니다.   
플레이어의 애니메이션을 위해 8프레임의 Run 모션을 직접 도트로 찍었지만, 도트에 익숙하지 않아 좋은 퀼리티가 아니였고, 이마저도 오랜시간이 걸려 개발이 지연됬습니다.
![playergit](https://user-images.githubusercontent.com/15938440/28751352-25544ba6-7540-11e7-925d-31539a50f5ba.png)

## 라이센스
None

## 제작
* [NotonAlcyone](notonalcyone@gmail.com):    디자인 프로그래밍 아트   
* [SeyaYura](https://www.facebook.com/Astralsoo): 아트
