using System;

namespace ProjectForBacis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Habib = new List<int>() { 7, 4, 8, 4, 5 }; // rounds result
            List<int> Conor = new List<int>() { 4, 6, 7, 8, 9 }; // rounds result

            List<int> result = Results(Habib, Conor);

            foreach (int item in result)
            {
                Console.Write($"{item} / ");
            }

            Console.WriteLine();

            int HabibScore, ConorScore;

            ResultScores(result, out HabibScore, out ConorScore);

            WhoIsWinner(HabibScore, ConorScore);

        }

        private static void ResultScores(List<int> result, out int HabibScore, out int ConorScore)
        {
            HabibScore = 0;
            ConorScore = 0;
            int i = 0;

            while (i < result.Count)
            {
                _ = (result[i] == 1) ? HabibScore++ : ConorScore++; // result we need not to store

                i++;
            }
        }

        private static void WhoIsWinner(int HabibScore, int ConorScore)
        {
            if (HabibScore > ConorScore)
            {
                Console.WriteLine($"Habib is winner: {HabibScore} : {ConorScore}");
            }
            else
            {
                Console.WriteLine($"Conor is winner: {ConorScore} : {HabibScore} ");
            }
        }

        /// <summary>
        /// Bu funksiya  ikki list ustida amal bajarib natijaviy listni qaytaradi
        /// </summary>
        /// <param name="Habib"></param>
        /// <param name="Conor"></param>
        /// <returns></returns>
        static List<int> Results(List<int> Habib, List<int> Conor)
        {
            List<int> EndResult = new List<int>();

            for(int i=0; i<Habib.Count; i++)
            {
                if (Habib[i] > Conor[i])
                {
                    EndResult.Add(1);
                }
                else
                {
                    EndResult.Add(0);
                }
            }


            return EndResult;
        }

        
    }
}