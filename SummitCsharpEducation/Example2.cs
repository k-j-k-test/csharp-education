using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummitCsharpEducation
{
    class Example2
    {
        public void ex2(string[] args)
        {
            Console.WriteLine("보험 위험률 데이터를 활용한 LINQ 예제");
            Console.WriteLine("===================================\n");

            // 1. 샘플 데이터 로드
            List<RiskRateTable> riskRates = CreateSampleData();
            Console.WriteLine($"총 {riskRates.Count}개의 위험률 데이터를 로드했습니다.\n");

            // 2. Select 예제
            Console.WriteLine("1. Select 연산자 예제");
            Console.WriteLine("------------------");

            // 예제 1-1: 기본 Select (위험률 이름과 성별만 추출)
            Console.WriteLine("예제 1-1: 위험률 이름과 성별 추출");
            var riskRateInfos = riskRates.Select(r => new {
                Name = r.RiskRateName,
                Gender = r.F1 == 1 ? "남성" : (r.F1 == 2 ? "여성" : "해당없음")
            });

            foreach (var info in riskRateInfos.Take(3))
            {
                Console.WriteLine($"위험률: {info.Name}, 성별: {info.Gender}");
            }
            Console.WriteLine();

            // 예제 1-2: 30세 위험률 정보만 추출
            Console.WriteLine("예제 1-2: 30세 위험률 정보 추출");
            var age30Rates = riskRates.Select(r => new {
                Name = r.RiskRateName,
                Gender = r.F1 == 1 ? "남성" : (r.F1 == 2 ? "여성" : "해당없음"),
                Rate = r.RiskRates[30] // 30세 위험률
            });

            foreach (var rate in age30Rates.Take(3))
            {
                Console.WriteLine($"위험률: {rate.Name}, 성별: {rate.Gender}, 30세 위험률: {rate.Rate:F6}");
            }
            Console.WriteLine();

            // 3. Where 예제
            Console.WriteLine("2. Where 연산자 예제");
            Console.WriteLine("------------------");

            // 예제 2-1: 남성 데이터만 필터링
            Console.WriteLine("예제 2-1: 남성 데이터만 필터링");
            var maleRiskRates = riskRates.Where(r => r.F1 == 1);
            Console.WriteLine($"남성 위험률 데이터 수: {maleRiskRates.Count()}");
            foreach (var rate in maleRiskRates.Take(2))
            {
                Console.WriteLine($"위험률: {rate.RiskRateName}, 성별: 남성");
            }
            Console.WriteLine();

            // 예제 2-2: 30세 위험률이 0.005 이상인 데이터 필터링
            Console.WriteLine("예제 2-2: 30세 위험률이 0.005 이상인 데이터 필터링");
            var highRiskRates = riskRates.Where(r => r.RiskRates[30] >= 0.005);
            Console.WriteLine($"30세 위험률이 0.005 이상인 데이터 수: {highRiskRates.Count()}");
            foreach (var rate in highRiskRates.Take(2))
            {
                Console.WriteLine($"위험률: {rate.RiskRateName}, 성별: {(rate.F1 == 1 ? "남성" : "여성")}, 30세 위험률: {rate.RiskRates[30]:F6}");
            }
            Console.WriteLine();

            // 4. OrderBy 예제
            Console.WriteLine("3. OrderBy 연산자 예제");
            Console.WriteLine("--------------------");

            // 예제 3-1: 위험률 이름으로 정렬
            Console.WriteLine("예제 3-1: 위험률 이름으로 오름차순 정렬");
            var orderedByName = riskRates.OrderBy(r => r.RiskRateName);
            foreach (var rate in orderedByName.Take(3))
            {
                Console.WriteLine($"위험률: {rate.RiskRateName}");
            }
            Console.WriteLine();

            // 예제 3-2: 30세 위험률 값으로 내림차순 정렬
            Console.WriteLine("예제 3-2: 30세 위험률 값으로 내림차순 정렬");
            var orderedBy30Rate = riskRates.OrderByDescending(r => r.RiskRates[30]);
            foreach (var rate in orderedBy30Rate.Take(3))
            {
                Console.WriteLine($"위험률: {rate.RiskRateName}, 성별: {(rate.F1 == 1 ? "남성" : "여성")}, 30세 위험률: {rate.RiskRates[30]:F6}");
            }
            Console.WriteLine();

            // 5. Dictionary 변환 예제
            Console.WriteLine("4. List를 Dictionary로 변환하기");
            Console.WriteLine("----------------------------");

            // 예제 4-1: 위험률 이름별로 데이터 그룹화하여 Dictionary 만들기
            Console.WriteLine("예제 4-1: 위험률 이름별로 데이터 그룹화");
            Dictionary<string, List<RiskRateTable>> riskRatesByName = new Dictionary<string, List<RiskRateTable>>();

            foreach (var riskRate in riskRates)
            {
                if (!riskRatesByName.ContainsKey(riskRate.RiskRateName))
                {
                    riskRatesByName[riskRate.RiskRateName] = new List<RiskRateTable>();
                }
                riskRatesByName[riskRate.RiskRateName].Add(riskRate);
            }

            Console.WriteLine("위험률 이름별 그룹화 결과 (상위 3개):");
            int count = 0;
            foreach (var pair in riskRatesByName)
            {
                Console.WriteLine($"위험률: {pair.Key}, 데이터 수: {pair.Value.Count}");
                count++;
                if (count >= 3) break;
            }
            Console.WriteLine();

            // 예제 4-2: Dictionary와 LINQ를 활용한 통계 계산
            Console.WriteLine("예제 4-2: Dictionary와 LINQ를 활용한 통계 계산");
            var avgRatesByName = riskRatesByName
                .ToDictionary(
                    pair => pair.Key,  // 키는 그대로 유지
                    pair => pair.Value.Average(r => r.RiskRates[30])  // 값은 30세 위험률 평균
                );

            var top3 = avgRatesByName
                .OrderByDescending(pair => pair.Value)
                .Take(3);

            Console.WriteLine("위험률 이름별 30세 평균 위험률 (상위 3개):");
            foreach (var pair in top3)
            {
                Console.WriteLine($"위험률: {pair.Key}, 30세 평균 위험률: {pair.Value:F6}");
            }
            Console.WriteLine();

            // 6. 복합 LINQ 쿼리 예제
            Console.WriteLine("5. 복합 LINQ 쿼리 예제");
            Console.WriteLine("---------------------");

            // 예제 5-1: 남성, 30세 위험률 0.005 이상, 상위 3개 추출
            Console.WriteLine("예제 5-1: 남성이면서 30세 위험률이 0.005 이상인 상위 3개 위험률");
            var topRiskRates = riskRates
                .Where(r => r.F1 == 1)
                .Where(r => r.RiskRates[30] >= 0.005)
                .OrderByDescending(r => r.RiskRates[30])
                .Take(3)
                .Select(r => new {
                    RiskName = r.RiskRateName,
                    Rate30 = r.RiskRates[30]
                });

            foreach (var rate in topRiskRates)
            {
                Console.WriteLine($"위험률: {rate.RiskName}, 30세 위험률: {rate.Rate30:F6}");
            }
            Console.WriteLine();

            // 예제 5-2: 연령대별 위험률 추세 분석
            Console.WriteLine("예제 5-2: 정기사망 위험률의 연령대별 추세");
            var ageGroupTrend = riskRates
                .Where(r => r.RiskRateName == "정기사망")
                .SelectMany(r => Enumerable.Range(0, 8).Select(decade => new {
                    Gender = r.F1 == 1 ? "남성" : "여성",
                    AgeGroup = $"{decade * 10}대",
                    AvgRate = Enumerable.Range(decade * 10, 10)
                              .Where(age => age < r.RiskRates.Length)
                              .Average(age => r.RiskRates[age])
                }))
                .OrderBy(x => x.Gender)
                .ThenBy(x => x.AgeGroup);

            Console.WriteLine("정기사망 위험률의 연령대별 추세:");
            foreach (var trend in ageGroupTrend)
            {
                Console.WriteLine($"성별: {trend.Gender}, 연령대: {trend.AgeGroup}, 평균 위험률: {trend.AvgRate:F6}");
            }

            Console.WriteLine("\n프로그램 종료. 아무 키나 누르세요...");
            Console.ReadKey();
        }
    }

    public class RiskRateTable
    {
        public string RiskRateName { get; set; }        // 위험률 이름
        public int F1 { get; set; }                     // 성별 (1=남성, 2=여성)
        public int F2 { get; set; }                     // 급수
        public int F3 { get; set; }                     // 운전자
        public int F4 { get; set; }                     // 금액
        public int F5 { get; set; }                     // 사고연령
        public int F6 { get; set; }                     // 가변 위험률팩터 1
        public int F7 { get; set; }                     // 가변 위험률팩터 2
        public int F8 { get; set; }                     // 가변 위험률팩터 3
        public int F9 { get; set; }                     // 가변 위험률팩터 4
        public string Date { get; set; }                // 기준 일자
        public double Face { get; set; }                // 위험률 계수
        public int Offset { get; set; }                 // 오프셋 값
        public double[] RiskRates { get; set; }         // 연령별 위험률 배열 (0~130세)
    }

}
