# 🚩StudyCSharp Repository

<img alt="C#" src="https://img.shields.io/badge/c%23%20-%23239120.svg?&style=for-the-badge&logo=c-sharp&logoColor=white"/>

## 🏳Contents
- C#이란
- 데이터 처리 및 보관
- 코드제어
- 클래스
- 인터페이스와 추상클래스
- 배열과 컬렉션
- 예외처리
- 대리자와 이벤트
- 스레드와 테스크
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

## ⌨기본 학습 자료
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

## 배열과 컬렉션

## ⌨기본 학습 자료
- [배열](https://github.com/WhiteHair-H/StudyCSharp21/tree/main/chap10/Chap10App)


### 🔑예제 코드
```
     class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 80, 74, 90, 65, 10 }; /*new int[5];
            scores[0] = 5;
            scores[1] = 10;
            scores[2] = 80;
            scores[3] = 74;
            scores[4] = 90;*/
            for (var i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"{i}의 점수는 {scores[i]}");
            }
```
---------------------------

## 예외처리

## ⌨기본 학습 자료
- [TryCatch](https://github.com/WhiteHair-H/StudyCSharp21/tree/main/chap12/Chap12App)


### 🔑예제 코드
```
     try
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                 result = x / y;
                 Console.WriteLine($"결과는 {result}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외발생했다 임마 {ex.Message}");
            }
```
---------------------------
## 대리자와 이벤트

## ⌨기본 학습 자료
- [Delegate](https://github.com/WhiteHair-H/StudyCSharp21/tree/main/chap13/Chap13App)


### 🔑예제 코드
```
      delegate void AllClac(int x, int y); // 대리자 선언
      
      Console.WriteLine("Calculating!");
            AllClac allClac = Plus;
             allClac += Minus;
             allClac += Divide;
             allClac += multiple;

            allClac(10, 5);
```
---------------------------
## 스레드와 태스크

## ⌨기본 학습 자료
- [Thread](https://github.com/WhiteHair-H/StudyCSharp21/tree/main/chap19/Chap19App)


### 🔑예제 코드
```
     static void Dosomething()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Dosomething : {i}");
                Thread.Sleep(10); // 1/100초 동안 멈춤
            }
        }
```
---------------------------


## 주소록 Project
### 콘솔로 만든 주소록

## ⌨Project 자료
- [Address Project](https://github.com/WhiteHair-H/StudyCSharp21/tree/main/chap99/AddressBookApp/AddressBookApp)

## 사용 프로그램
- visual studio code
<img src = "https://venturebeat.com/wp-content/uploads/2019/11/visual-studio-logo.jpeg?w=930&strip=all" width = "300" height = "100"/>


### 📷주소록 결과창
![결과1](/ref_Imagefiles/Address1.JPG "처음화면")
![결과2](/ref_Imagefiles/Address2.JPG "주소입력")
![결과3](/ref_Imagefiles/Address3.JPG "주소검색")
![결과4](/ref_Imagefiles/Address4.JPG "주소수정")
![결과5](/ref_Imagefiles/Address5.JPG "주소삭제")
![결과6](/ref_Imagefiles/Address6.JPG "주소전체출력")
![결과7](/ref_Imagefiles/Address7.JPG "주소 파일저장")

---------------------------


