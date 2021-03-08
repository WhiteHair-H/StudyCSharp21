# 🚩StudyCSharp Repository

## 🏳Contents
- C#이란
- C# 기초
- 데이터 처리 및 보관
- 코드제어
- 클래스
- 인터페이스와 추상클래스
- 프로퍼티
- 배열과 컬렉션
- 예외처리
- 대리자와 이벤트
- 람다식
- LINQ
- 리플렉션과 애트리뷰트
- 스레드와 테스크
- WINFORM
- 가비지 

## ⏰기간
- [2021-02-22] ~ [2021-03-08]

--------------------------

## C#이란
- C++ 기반으로 JAVA의 장점을 혼합하고, 닷넷이라는 새로운 개념을 도입한 언어
### C#의 특징
- 객체 지향 언어
- 적용분야의 다양성(콘솔, 윈도우, 인터넷 응용프로그램)
- C언어로부터 연산자와 문장 등 기본적인 언어의 기능 상속
- C++로부터 객체지향 특성상속

--------------------------

## C# 기초
### 🏳Contents
- Using System
- HelloWorld


### 🔑예제 코드
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstTestApp
{ 
    class Program
    {
        enum Season
        {
            Spring = 1000, 
            summer = 2000,
            Fall = 3000,
            Winter = 4000
        }
        static void Main(string[] args)
        {
            Console.WriteLine("상수테스트");
            const double PI = 3.141592;
            Console.WriteLine($"원주율의 값은 {PI}");
            //PI = 6.345;
            Season mySeason = Season.Winter; // error(Season)3;//Season.summer;
            Console.WriteLine($"지금 계절은 {mySeason}입니다");
            int a = 0;
            Console.WriteLine($"a는 {a}");
            int? b = null;
            Console.WriteLine($"b는 {b}");
        }
    }
}
```

---------------------------

## Responsive Web 기본 학습
### 🏳Contents
- Responsive Web 소개
- Responsive Web 설정
- Responsive Web 패턴

## ⌨Responsive Web 기본 학습 자료
- [Responsive Web](https://github.com/WhiteHair-H/StudyHtml/tree/main/02_CSS)

### 🔑예제 코드
```
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <meta name='viewport' content='width=device-width, initial-scale=1'>
```

---------------------------

## Javascript 기본 학습
### 🏳Contents
- Javascript 기본 문법
- 문서 객체 모델
- JQuery 라이브러리

## ⌨Javascript 기본 학습 자료
- [Javascript](https://github.com/WhiteHair-H/StudyHtml/tree/main/03_javascript)


### 🔑예제 코드
```
      <script src="https://code.jquery.com/jquery-3.1.0.js"></script>
    <script>
        // 이벤트를 연결합니다.
        $(document).ready(function () {
            // 10회 반복합니다.
            for (var i = 0; i < 10; i++) {
                // 문서 객체를 생성합니다.
                $('<h1>Create Document Object + ' + i + '</h1>').css({
                    backgroundColor: 'black',
                    color: 'red'  
                }).appendTo('body');
                
            }
        });
    </script>
```
---------------------------


## Project
### 전체 통합 프로젝트
- 홈페이지 제작

## ⌨Project 기본 학습 자료
- [Project](https://github.com/WhiteHair-H/StudyHtml/commit/17a5896c30be2415a40f209e526a6b9c5b766925)

## 사용 프로그램
- visual studio code
<img src = "https://pbs.twimg.com/profile_images/1278357302601347072/BGZIBPH9_400x400.jpg" width = "80" height = "80"/>


#### 반응형 웹 그리드 레이아웃 웹 페이지 실습
![결과1](/ref_images/result001.png "전체 레이아웃")
![결과2](/ref_images/result002.png "팝업 레이아웃")


---------------------------


