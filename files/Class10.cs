using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class Cricket
    {
        static int TotalScore = 0;
        int IndividualScore = 0;
        public static void ShowScore()
        {
            Console.WriteLine($"TeamScore : {TotalScore}");
        }
        public void ShowPlayerScore(string playerName,int IndividualScore)
        {
            Console.WriteLine($"{playerName}  Scored :{IndividualScore}");
            TotalScore += IndividualScore;
        }
    }
    internal class Class10
    {
        static void Main(string[] args)
        {
            Cricket kohli =new Cricket();
            Cricket.ShowScore(); ;
            kohli.ShowPlayerScore("kohli",50);
            Cricket.ShowScore(); ;
            Cricket Rohit = new Cricket();
            Rohit.ShowPlayerScore("Rohit", 30);
            Cricket.ShowScore(); ;
        }
    }
}
