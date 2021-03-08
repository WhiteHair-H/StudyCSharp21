# 🚩StudyCSharp Repository

## 🏳Contents
- C#이란
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
- 주소록 

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

## C# 데이터 처리 및 보관
### 🏳Contents
- 기초
- 데이터 처리
- 데이터  

## ⌨기본 학습 자료
- [Base](https://github.com/WhiteHair-H/StudyCSharp21/commit/4ed8ec0df86ed6209d12c39e3bc27e3d55fce1e9)


### 🔑예제 코드
```
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

```

---------------------------

## 클래스
### 🏳Contents
- Class

## ⌨기본 학습 자료
- [Class](https://github.com/WhiteHair-H/StudyCSharp21/tree/main/chap05/chap05App)

### 🔑예제 코드
```
   class Program
    { static void Main(string[] args)
        {
            //if문
            while (true)
            {
                Console.Write("수를 입력하세요 : ");
                string line = Console.ReadLine(); // 콘솔에서 입력값을 변수할당

                if (line == "quit") break; // quit 입력시 종료
                {
                }
```

---------------------------

## 인터페이스 및 추상클래스
### 🏳Contents
- 인터페이스
- 추상클래스

## ⌨Javascript 기본 학습 자료
- [InterFace](https://github.com/WhiteHair-H/StudyCSharp21/tree/main/chap08/Chap08App)


### 🔑예제 코드
```
      interface ILogger
    {
        void writeLog(string msg);
    }
    class ConsoleLogger : ILogger
    {
        public void writeLog(string msg)
        {
            Console.WriteLine($"{DateTime.Now.ToShortDateString()} log : {msg}");
        }
    }
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


