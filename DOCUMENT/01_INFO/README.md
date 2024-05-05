# 아두이노와 웹을 활용한 사물인터넷

학습목표
---
> 아두이노와 웹 애플리케이션을 연결하는 경험을 통해 컴퓨팅 통신 구조를 이해하고, 정보 통신 기술(ICT) 분야의 직업 정보 및 경로를 탐색한다.


기본개념 소개
---
#### 프로그램이란
---
> 진행 계획이나 순서, 잘짜여진 순서의 묶음 <br><br>
![download](https://github.com/MY-ALL-LECTURE/DREAM-LOAD/assets/84259104/26c11d1a-ab75-47dd-9880-fd56e14a9911)

#### 소프트웨어 vs 하드웨어
---
|하드웨어|-|소프트웨어|
|-|-|-|
|부품|-|하드웨어를 동작시키는 프로그램|
|![images](https://github.com/MY-ALL-LECTURE/DREAM-LOAD/assets/84259104/f6c18eac-bea5-4b57-9c43-bc2cb5cf7f6d)|-|![download](https://github.com/MY-ALL-LECTURE/DREAM-LOAD/assets/84259104/b0579c54-d1fc-4ec3-b6bb-ed8c3deaa048)|


#### 소프트웨어 종류
---

|시스템 S/W|-|APPLICATION|
|-|-|-|
|HardWare를 제어|-|사용자의목적달성|
|<img src="https://github.com/MY-ALL-LECTURE/PYTHON/assets/84259104/8e2cd21c-fe96-49b6-8c94-0cd05c73a26c" width="400px" height="200px" />|-|<img src="https://github.com/MY-ALL-LECTURE/PYTHON/assets/84259104/e5a2f3ad-2074-43dd-ab30-ef395a0b4e0a" width="400px" height="200px" /> |


#### 시스템
---
> 하드웨어와 소프트웨어로 구성
> 특정 목표를 달성하기 위한 체계적인 집합

|-|
|-|
|<img width=450px height=300px src="https://www.shutterstock.com/shutterstock/photos/2128036841/display_1500/stock-vector--s-retro-vaporwave-aesthetics-digital-screen-user-interface-cute-old-computer-ui-elements-2128036841.jpg" /> |
|<img width=450px height=300px src="https://previews.123rf.com/images/aleksorel/aleksorel1707/aleksorel170700022/82180102-cpu-%EC%B9%A9-%EB%B0%8F-%EC%BB%B4%ED%93%A8%ED%84%B0-%EA%B5%AC%EC%84%B1-%EC%9A%94%EC%86%8C%EB%A5%BC-%EB%B2%A1%ED%84%B0-%EC%9D%BC%EB%9F%AC%EC%8A%A4%ED%8A%B8-%EB%A0%88%EC%9D%B4-%EC%85%98-%ED%95%98%EB%93%9C%EC%9B%A8%EC%96%B4-%EC%9A%94%EC%86%8C-cpu-%EC%B9%A9-%ED%82%A4%EB%B3%B4%EB%93%9C-%EB%9E%A8-%EB%A9%94%EB%AA%A8%EB%A6%AC-%ED%95%98%EB%93%9C-%EB%94%94%EC%8A%A4%ED%81%AC-%ED%94%84%EB%A1%9C%EC%84%B8%EC%84%9C-%EB%93%B1-%EB%9D%BC%EC%9D%B8-%EC%95%84%ED%8A%B8-%EC%BB%B4%ED%93%A8%ED%84%B0-%EC%8B%9C%EC%8A%A4%ED%85%9C.jpg" />|
|-|


#### 플랫폼
---
> 어플리케이션을 작동시키기 위한 "기반 OS"나 "기술환경"을 의미
> 시스템등이 제공되는 환경

|용어|풀이|기타|
|-|-|-|
|PC|범용 시스템|-|
|EMBEDDED|미리 정해진 특정 기능을 수행하기 위한 하드웨어와 소프트웨어가 내장된 시스템|-|
|IOT(Internet of Things|IoT는 다양한 객체나 장치들이 인터넷을 통해 서로 연결되고 상호 작용할 수 있는 컨셉|-|

#### 네트워크
---
> 여러 컴퓨터나 기타 장치들이(or 시스템) 데이터를 주고받을 수 있도록 연결된 구조를 의미<br>
> Keyword : 연결과 공유<br>

#### 아키텍처란
---
> 시스템의 구조, 동작 등을 정의하는 개념적인 모형으로 시스템의 목적을 달성하기 위해 시스템의 각 컴포넌트가 무엇이며 어떻게 상호작용 하는지, 정보가 어떻게 교환되는 지를 설명<br>

> 제작할 목표물에 대한 설계도<br>

|-|
|-|
|<img src="https://pixabay.kr/data/file/notice/thumb-1596478864771_835x470.jpg"|


[참고] IOT vs Embedded 
---
```
 범위와 연결성: 임베디드 시스템은 주로 독립적인 장치나 제품 안에서 작동하며, 한정된 기능을 수행합니다. 반면에 IoT는 여러 장치가 인터넷을 통해 연결되어 데이터 교환과 원격 제어를 가능하게 합니다.
 통신과 네트워킹: 임베디드 시스템은 일방향적인 목적을 위해 설계되었으며, 일반적으로 복잡한 통신 기능을 가지지 않습니다. IoT는 다양한 장치 간의 양방향 통신과 네트워킹을 강조합니다.
 크기와 리소스: 임베디드 시스템은 작고 경량화된 리소스를 사용하여 특정한 임무를 수행하는 것이 목표입니다. IoT는 다양한 종류의 장치들로 구성되며, 네트워크와 연결을 위해 더 많은 리소스를 필요로 합니다.
 자동화와 제어: 임베디드 시스템은 주로 자동화된 작업을 수행하고 외부 개입 없이 작동합니다. IoT는 더욱 복잡한 상호 작용과 원격 제어를 가능하게 하여 사람의 개입을 포함할 수 있습니다.
```

##### --------------------------------------------
##### 03 아두이노
##### --------------------------------------------
##### - 아두이노란		:	오픈 소스를 기반으로 한 단일 보드 '마이크로컨트롤러'
#####  			            하드웨어(아두이노보드) + 소프트웨어(OPEN Sorce IDE,Library)
##### - 마이크로컨트롤러(MCU)	: 	마이크로프로세서 + 메모리  + 입출력모듈
##### 				컴퓨터 본체의 기능을 하나의 칩 위에 구현
##### 				전원만 주어지면 컴퓨터로 동작 : 저전력으로 이용
##### 				입출력 장치 연결로 완전한 컴퓨터로서 동작 가능
##### 				[참고]	https://velog.io/@woo0_hooo/%EC%95%84%EB%91%90%EC%9D%B4%EB%85%B8-MCU%EC%97%90-%EB%8C%80%ED%95%B4-%EC%95%8C%EC%95%84%EB%B3%B4%EC%9E%90	

##### --------------------------------------------
##### 04 아두이노 플랫폼
##### --------------------------------------------
##### - https://m.blog.naver.com/bpcode/221833337444
##### - https://kogun.tistory.com/15
##### - https://blog.naver.com/agapeuni/220075883314
##### - https://recall.tistory.com/21

##### --------------------------------------------
##### 05 아두이노 우노 보드 구성 및 기본 요소
##### --------------------------------------------
##### - 기본 구성품 : https://jaebaeklee.tistory.com/49
##### - 브레드 보드 : https://meaningone.tistory.com/333


# 환경 설정
##### 아두이노 IDE : https://www.arduino.cc/en/software
##### 아두이노 확장 CH340 드라이버 : https://sparks.gogo.co.nz/ch340.html


# 참고
##### 아두이노 예제모음 : https://github.com/FN-BN-EDU-ORGANIZATION/07EMBEDDED/new/main?readme=1
##### 아두이노 가상시뮬레이터 : https://www.tinkercad.com/things/6rolzI0MH9r-bodacious-sango-fulffy/editel?tenant=circuits
