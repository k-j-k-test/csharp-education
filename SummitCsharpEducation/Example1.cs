using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummitCsharpEducation
{
    public class Example1
    {
        public void WriteHelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        public void DemonstrateBasicTypes()
        {
            Console.WriteLine("=== 기본 타입 사용 예시 ===\n");

            // 1. int 타입 (32비트 정수)
            Console.WriteLine("--- int 타입 ---");
            int intNumber = 42;
            int intResult = intNumber * 2;
            int intMin = int.MinValue;
            int intMax = int.MaxValue;

            Console.WriteLine($"int 값: {intNumber}");
            Console.WriteLine($"int 연산 (곱하기 2): {intResult}");
            Console.WriteLine($"int 최소값: {intMin:N0}");
            Console.WriteLine($"int 최대값: {intMax:N0}");

            // 2. double 타입 (64비트 부동소수점)
            Console.WriteLine("\n--- double 타입 ---");
            double doubleNumber = 3.14159;
            double doubleResult = Math.Round(doubleNumber * 2, 2);

            Console.WriteLine($"double 값: {doubleNumber}");
            Console.WriteLine($"double 연산 (곱하기 2): {doubleResult}");
            Console.WriteLine($"double 정밀 계산: {Math.Sqrt(doubleNumber):F4}");

            // 3. char 타입 (16비트 유니코드 문자)
            Console.WriteLine("\n--- char 타입 ---");
            char charValue = 'A';
            char koreanChar = '가';
            int charCode = charValue;

            Console.WriteLine($"char 값: {charValue}");
            Console.WriteLine($"한글 char: {koreanChar}");
            Console.WriteLine($"char의 ASCII/유니코드 값: {charCode}");
            Console.WriteLine($"다음 문자: {(char)(charValue + 1)}");

            // 4. string 타입 (문자열)
            Console.WriteLine("\n--- string 타입 ---");
            string message = "안녕하세요";
            string combined = message + ", C#!";
            string substring = combined.Substring(0, 5);

            Console.WriteLine($"string 값: {message}");
            Console.WriteLine($"문자열 결합: {combined}");
            Console.WriteLine($"부분 문자열: {substring}");
            Console.WriteLine($"문자열 길이: {message.Length}");
            Console.WriteLine($"대문자 변환: {combined.ToUpper()}");
        }

        public void DemonstrateBasicTypeOperators()
        {
            Console.WriteLine("=== 기본 타입 연산자 예시 ===\n");

            // 1. int 타입 연산자
            Console.WriteLine("--- int 연산자 ---");
            int a = 10, b = 3;

            Console.WriteLine($"더하기(+): {a} + {b} = {a + b}");
            Console.WriteLine($"빼기(-): {a} - {b} = {a - b}");
            Console.WriteLine($"곱하기(*): {a} * {b} = {a * b}");
            Console.WriteLine($"나누기(/): {a} / {b} = {a / b}");    // 정수 나눗셈은 소수점 버림
            Console.WriteLine($"나머지(%): {a} % {b} = {a % b}");
            Console.WriteLine($"증가(++): {a}++ = {a++}, 새 값 = {a}");  // 후위 증가
            Console.WriteLine($"감소(--): {a}-- = {a--}, 새 값 = {a}");  // 후위 감소
            Console.WriteLine($"비교(>): {a} > {b} = {a > b}");
            Console.WriteLine($"비교(==): {a} == {b} = {a == b}");

            // 2. double 타입 연산자
            Console.WriteLine("\n--- double 연산자 ---");
            double x = 10.5, y = 2.5;

            Console.WriteLine($"더하기(+): {x} + {y} = {x + y}");
            Console.WriteLine($"빼기(-): {x} - {y} = {x - y}");
            Console.WriteLine($"곱하기(*): {x} * {y} = {x * y}");
            Console.WriteLine($"나누기(/): {x} / {y} = {x / y}");  // 실수 나눗셈
            Console.WriteLine($"비교(>=): {x} >= {y} = {x >= y}");
            Console.WriteLine($"Math.Pow(): {x}^2 = {Math.Pow(x, 2)}");

            // 3. char 타입 연산자
            Console.WriteLine("\n--- char 연산자 ---");
            char c1 = 'A', c2 = 'B';

            Console.WriteLine($"비교(>): '{c1}' > '{c2}' = {c1 > c2}");
            Console.WriteLine($"산술(+): '{c1}' + 1 = '{(char)(c1 + 1)}'");
            Console.WriteLine($"문자 코드: '{c1}' = {(int)c1}, '{c2}' = {(int)c2}");
            Console.WriteLine($"차이: '{c2}' - '{c1}' = {c2 - c1}");

            // 4. string 타입 연산자
            Console.WriteLine("\n--- string 연산자 ---");
            string s1 = "Hello", s2 = "World";

            Console.WriteLine($"연결(+): {s1} + {s2} = \"{s1 + s2}\"");
            Console.WriteLine($"문자열 보간($): $\"{{s1}} {{s2}}!\" = \"{s1} {s2}!\"");
            Console.WriteLine($"문자 접근([]): {s1}[0] = '{s1[0]}'");
            Console.WriteLine($"비교(==): {s1} == {s2} = {s1 == s2}");
            Console.WriteLine($"문자열 비교: s1.Equals(s2) = {s1.Equals(s2)}");
            Console.WriteLine($"문자열 비교(대소문자 무시): s1.Equals(\"hello\", StringComparison.OrdinalIgnoreCase) = {s1.Equals("hello", StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"null 병합(??): null ?? \"기본값\" = {null ?? "기본값"}");

            // null 조건부 연산자 및 문자열 보간 확장 예제
            string nullString = null;
            Console.WriteLine($"null 조건부(?): nullString?.Length = {nullString?.Length}");

            // 문자열 보간 내에서 조건부 연산자 사용
            int score = 85;
            Console.WriteLine($"삼항 연산자: 점수는 {score}점으로 {(score >= 80 ? "통과" : "실패")}입니다.");

            // 5. bool 타입 연산자
            Console.WriteLine("\n--- bool 연산자 ---");
            bool p = true, q = false;

            Console.WriteLine($"논리적 AND(&&): {p} && {q} = {p && q}");
            Console.WriteLine($"논리적 OR(||): {p} || {q} = {p || q}");
            Console.WriteLine($"논리적 NOT(!): !{p} = {!p}, !{q} = {!q}");
            Console.WriteLine($"논리적 XOR(^): {p} ^ {q} = {p ^ q}");
            Console.WriteLine($"논리적 XOR(^): {p} ^ {p} = {p ^ p}");
            Console.WriteLine($"동등 비교(==): {p} == {q} = {p == q}");
            Console.WriteLine($"부등 비교(!=): {p} != {q} = {p != q}");

            // 조건부 연산과 함께 사용
            int value = 42;
            bool isPositive = value > 0;
            bool isEven = value % 2 == 0;

            Console.WriteLine($"value({value})는 양수인가? {isPositive}");
            Console.WriteLine($"value({value})는 짝수인가? {isEven}");
            Console.WriteLine($"양수이면서 짝수인가? {isPositive && isEven}");
            Console.WriteLine($"양수이거나 짝수인가? {isPositive || isEven}");

        }

        public void DemonstrateImplicitTypeCasting()
        {
            // 정수에서 실수로의 암시적 형변환
            int number = 500;
            double doubleValue = number;  // int에서 double로 암시적 형변환
            Console.WriteLine($"int 값 {number}을(를) double로 암시적 변환: {doubleValue}");
        }

        public void DemonstrateExplicitTypeCasting()
        {
            // 실수에서 정수로의 명시적 형변환 (소수점 이하 손실)
            double doubleValue = 9.78;
            int intValue = (int)doubleValue; // double에서 int로 명시적 형변환
            Console.WriteLine($"double 값 {doubleValue}을(를) int로 명시적 변환: {intValue}");

            // Convert 클래스를 사용한 형변환
            string numberString = "123";
            int convertedNumber = Convert.ToInt32(numberString);
            Console.WriteLine($"문자열 \"{numberString}\"을(를) Convert.ToInt32로 변환: {convertedNumber}");

            // Parse 메서드를 사용한 형변환
            string anotherNumber = "456";
            int parsedNumber = int.Parse(anotherNumber);
            Console.WriteLine($"문자열 \"{anotherNumber}\"을(를) int.Parse로 변환: {parsedNumber}");

            // TryParse 메서드를 사용한 안전한 형변환
            string invalidNumber = "abc";
            bool success = int.TryParse(invalidNumber, out int result);
            Console.WriteLine($"문자열 \"{invalidNumber}\"을(를) int.TryParse로 변환: {(success ? "성공 " + result : "실패")}");

            // ToString 메서드를 사용한 문자열 변환
            int numValue = 42;
            string numString = numValue.ToString();
            Console.WriteLine($"int 값 {numValue}을(를) ToString()으로 문자열 변환: \"{numString}\"");

            // ToString 포맷 지정
            double pi = Math.PI;
            string piFormatted = pi.ToString("F2"); // 소수점 2자리까지
            Console.WriteLine($"double 값 {pi}을(를) ToString(\"F2\")로 변환: \"{piFormatted}\"");

            // 다양한 ToString 포맷
            double amount = 1234.56;
            Console.WriteLine($"통화 형식: {amount.ToString("C")}");    // ₩1,234.56
            Console.WriteLine($"백분율 형식: {(0.1234).ToString("P")}"); // 12.34%

            // DateTime의 ToString
            DateTime now = DateTime.Now;
            Console.WriteLine($"현재 날짜/시간: {now.ToString()}");
            Console.WriteLine($"날짜 형식: {now.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"시간 형식: {now.ToString("HH:mm:ss")}");
        }

        public void DemonstrateBoxingAndUnboxing()
        {
            // 박싱(Boxing)과 언박싱(Unboxing) 예시를 보여주는 메서드
            // 값 타입을 참조 타입(object)으로 변환하거나, 그 반대로 변환하는 과정

            // 박싱(Boxing) - 값 타입을 참조 타입(object)으로 변환
            int intValue = 100;
            object boxedInt = intValue; // int 값이 object로 박싱됨
            Console.WriteLine($"박싱: int 값 {intValue}을(를) object로 변환 => {boxedInt}");

            // 언박싱(Unboxing) - 참조 타입(object)을 다시 값 타입으로 변환
            int unboxedInt = (int)boxedInt; // 명시적 캐스팅 필요
            Console.WriteLine($"언박싱: object를 다시 int로 변환 => {unboxedInt}");

            // 다른 타입의 박싱 예시
            double doubleValue = 3.14;
            object boxedDouble = doubleValue; // double이 object로 박싱됨
            Console.WriteLine($"박싱: double 값 {doubleValue}을(를) object로 변환 => {boxedDouble}");

            // 잘못된 타입으로 언박싱 시도
            try
            {
                // int로 박싱된 값을 double로 언박싱 시도 (실패)
                double incorrectUnboxing = (double)boxedInt;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"잘못된 언박싱 시도 시 예외 발생: {ex.Message}");
            }

            // as 연산자 사용 (참조 타입에만 사용 가능하므로 값 타입에는 직접 사용 불가)
            string strValue = "테스트";
            object boxedString = strValue;
            string unboxedString = boxedString as string; // as 연산자 사용
            Console.WriteLine($"참조 타입 언박싱(as 연산자): {unboxedString}");
        }

        public void DemonstrateIntegerOverflow()
        {
            // int 타입의 최대값 2,147,483,647
            int maxValue = int.MaxValue;
            Console.WriteLine("int의 최대값: " + maxValue);

            // 오버플로우 발생 예시 1: 최대값에 1을 더함
            int overflow1 = maxValue + 1;
            Console.WriteLine("최대값 + 1의 결과(오버플로우): " + overflow1);

            // 오버플로우 발생 예시 2: 큰 수를 곱함
            int a = 1000000;
            int b = 3000;
            int overflow2 = a * b;
            Console.WriteLine($"{a} * {b}의 결과(오버플로우): " + overflow2);
        }

        public void DemonstrateValueVsReference()
        {
            Console.WriteLine("=== 값 타입과 참조 타입의 차이 ===\n");

            // 1. 값 타입 (int) - 복사본이 전달됨
            int a = 10;
            int b = a;  // 값 복사

            Console.WriteLine("값 타입:");
            Console.WriteLine($"  초기값: a = {a}, b = {a}");

            b = 20;  // b만 변경
            Console.WriteLine($"  b 변경 후: a = {a}, b = {b}");  // a는 그대로 유지

            // 2. 참조 타입 (배열) - 참조(주소)가 전달됨
            int[] array1 = { 1, 2, 3 };
            int[] array2 = array1;  // 참조 복사 (같은 배열을 가리킴)

            Console.WriteLine("\n참조 타입(배열):");
            Console.WriteLine($"  초기값: array1[0] = {array1[0]}, array2[0] = {array2[0]}");

            array2[0] = 99;  // array2를 통해 변경
            Console.WriteLine($"  array2[0] 변경 후: array1[0] = {array1[0]}, array2[0] = {array2[0]}");  // array1도 변경됨

            // 3. 참조 타입 (Person 클래스) - 참조(주소)가 전달됨
            Person person1 = new Person("홍길동", 30);
            Person person2 = person1;  // 참조 복사 (같은 객체를 가리킴)

            Console.WriteLine("\n참조 타입(Person):");
            Console.WriteLine($"  초기값: person1.Name = {person1.Name}, person2.Name = {person2.Name}");

            person2.Name = "김철수";  // person2를 통해 변경
            Console.WriteLine($"  person2.Name 변경 후: person1.Name = {person1.Name}, person2.Name = {person2.Name}");  // person1도 변경됨
        }

        public void DemonstrateArray()
        {
            // 배열 생성
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            string[] fruits = { "사과", "바나나", "오렌지" };

            // 배열 요소 접근
            Console.WriteLine($"numbers[0]: {numbers[0]}");
            Console.WriteLine($"fruits[1]: {fruits[1]}");

            // 배열 요소 수정
            numbers[2] = 30;

            // 배열 순회
            Console.WriteLine("numbers 배열 순회:");
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            // 다차원 배열
            int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine($"matrix[1,2]: {matrix[1, 2]}");

            // 배열 길이
            Console.WriteLine($"numbers 길이: {numbers.Length}");

            // 배열 메서드
            int index = Array.IndexOf(fruits, "바나나");
            Console.WriteLine($"\"바나나\"의 인덱스: {index}");
        }

        public void DemonstrateList()
        {
            // List 생성
            List<string> names = new List<string>();
            names.Add("홍길동");
            names.Add("김철수");
            names.Add("이영희");

            // 초기화와 함께 생성
            List<int> scores = new List<int> { 95, 80, 75, 90 };

            // 요소 접근
            Console.WriteLine($"첫 번째 이름: {names[0]}");

            // 요소 추가/삽입
            names.Add("박지성");
            names.Insert(1, "정민호");

            // List 순회
            Console.WriteLine("이름 목록:");
            foreach (string name in names)
            {
                Console.WriteLine($"- {name}");
            }

            // List 검색
            bool contains = names.Contains("이영희");
            int index = names.IndexOf("박지성");
            Console.WriteLine($"\"이영희\" 포함 여부: {contains}");
            Console.WriteLine($"\"박지성\"의 인덱스: {index}");

            // 기타 작업
            int count = names.Count;
            names.Clear();

            Console.WriteLine($"이름 목록 개수: {count}, 비우기 후: {names.Count}");
        }

        public void DemonstrateHashSet()
        {
            // HashSet 생성
            HashSet<string> uniqueNames = new HashSet<string>();
            uniqueNames.Add("홍길동");
            uniqueNames.Add("김철수");
            uniqueNames.Add("이영희");

            // 초기화와 함께 생성
            HashSet<int> uniqueNumbers = new HashSet<int> { 1, 2, 3, 5, 8 };

            // 중복 요소 추가 시도 (무시됨)
            bool added = uniqueNames.Add("홍길동");
            Console.WriteLine($"중복 이름 추가 성공?: {added}");

            // 요소 포함 여부
            bool contains = uniqueNames.Contains("김철수");
            Console.WriteLine($"\"김철수\" 포함 여부: {contains}");

            // HashSet 순회
            Console.WriteLine("고유 이름 목록:");
            foreach (string name in uniqueNames)
            {
                Console.WriteLine($"- {name}");
            }

            // 집합 연산
            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> setB = new HashSet<int> { 3, 4, 5, 6, 7 };

            // 합집합
            setA.UnionWith(setB);
            Console.WriteLine("합집합 결과: " + string.Join(", ", setA));

            // 교집합
            HashSet<int> setC = new HashSet<int> { 1, 2, 3, 4, 5 };
            setC.IntersectWith(setB);
            Console.WriteLine("교집합 결과: " + string.Join(", ", setC));

            // 개수
            int count = uniqueNames.Count;
            Console.WriteLine($"개수: {count}");
        }

        public void DemonstrateDictionary()
        {
            // Dictionary 생성
            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("홍길동", 30);
            ages.Add("김철수", 25);
            ages.Add("이영희", 28);

            // 초기화와 함께 생성
            Dictionary<string, string> capitals = new Dictionary<string, string>
            {
                { "대한민국", "서울" },
                { "일본", "도쿄" },
                { "미국", "워싱턴 D.C." }
            };

            // 요소 접근 및 수정
            int hongAge = ages["홍길동"];
            ages["김철수"] = 26;
            Console.WriteLine($"홍길동의 나이: {hongAge}");
            Console.WriteLine($"김철수의 수정된 나이: {ages["김철수"]}");

            // 안전하게 값 가져오기
            if (ages.TryGetValue("박지성", out int parkAge))
            {
                Console.WriteLine($"박지성의 나이: {parkAge}");
            }
            else
            {
                Console.WriteLine("박지성의 정보가 없습니다.");
            }

            // 키 존재 여부 확인
            bool containsKey = capitals.ContainsKey("중국");
            Console.WriteLine($"\"중국\" 키 포함 여부: {containsKey}");

            // Dictionary 순회
            Console.WriteLine("나라별 수도:");
            foreach (KeyValuePair<string, string> pair in capitals)
            {
                Console.WriteLine($"- {pair.Key}: {pair.Value}");
            }

            // 키와 값 컬렉션
            Dictionary<string, int>.KeyCollection keys = ages.Keys;
            Dictionary<string, int>.ValueCollection values = ages.Values;

            Console.WriteLine("모든 이름: " + string.Join(", ", keys));
            Console.WriteLine("모든 나이: " + string.Join(", ", values));

            // 개수 및 비우기
            int count = ages.Count;
            ages.Clear();
            Console.WriteLine($"원래 개수: {count}, 비우기 후: {ages.Count}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"안녕하세요, 제 이름은 {Name}이고, 나이는 {Age}세입니다.");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name}가 걷고 있습니다.");
        }

        public virtual void Sleep()
        {
            Console.WriteLine($"{Name}가 자고 있습니다.");
        }
    }

    class Student : Person
    {
        public int Score { get; set; }

        public Student(string name, int age) : base(name, age)
        {

        }

        public void Study()
        {
            Console.WriteLine($"{Name}가 공부하고 있습니다.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{Name}가 공부하느라 늦게 자고 있습니다.");
        }
    }
}
