using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SummitCsharpEducation
{
    class Example2
    {
        public List<RiskRateTable> RiskRateList { get; set; } = new List<RiskRateTable>();

        public void ReadRiskRateTable()
        {
            StreamReader sr = new StreamReader(@"ExampleSource\RiskRates.txt", Encoding.Default);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] parts = line.Split('\t');

                RiskRateTable riskRate = new RiskRateTable
                {
                    RiskRateName = parts[0],
                    F1 = parts[1] == "" ? 0 : int.Parse(parts[1]),
                    F2 = parts[2] == "" ? 0 : int.Parse(parts[2]),
                    F3 = parts[3] == "" ? 0 : int.Parse(parts[3]),
                    F4 = parts[4] == "" ? 0 : int.Parse(parts[4]),
                    F5 = parts[5] == "" ? 0 : int.Parse(parts[5]),
                    F6 = parts[6] == "" ? 0 : int.Parse(parts[6]),
                    F7 = parts[7] == "" ? 0 : int.Parse(parts[7]),
                    F8 = parts[8] == "" ? 0 : int.Parse(parts[8]),
                    F9 = parts[9] == "" ? 0 : int.Parse(parts[9]),
                    Date = parts[10],
                    Face = double.Parse(parts[11]),
                    Offset = int.Parse(parts[12]),   
                };

                riskRate.RiskRates = new double[131];
                for (int i = 0; i < 131; i++)
                {
                    riskRate.RiskRates[i] = parts[13 + i] == "" ? 0 : double.Parse(parts[13 + i]);
                }

                RiskRateList.Add(riskRate);
            }
        }

        public void SelectRiskRateTable()
        {
            // RiskRateName, F1, RiskRates[30]를 선택 (메서드 체이닝)
            List<string> strings = RiskRateList
                .Where(r => r.F1 == 1)
                .Select(r => $"{r.RiskRateName}, {r.F1}, {r.RiskRates[30]}")
                .ToList();

            // 콘솔에 출력
            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }
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
