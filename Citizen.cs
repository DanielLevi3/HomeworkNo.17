using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17._07._20
{
    class Citizen
    {
        public string m_name;
        public Citizen[] children = new Citizen[]
        {

        };
        public readonly int m_fatherID;
        public readonly int m_ID; //1:0//2:1//3:2
        public static int m_NumberOfCurrentCitizens = 0; // 0
        public const int maximumNumberOfCitizens = 100000;
        public Citizen(string name, int fatherID)
        {
            this.m_name = name;
            this.m_fatherID = fatherID;
            m_NumberOfCurrentCitizens++;//0,1,2
            m_ID = fatherID--;
        }

        public static void PrintNumberOfCitizens()
        {
            Console.WriteLine(m_NumberOfCurrentCitizens);
        }
        public static bool ReachedHalfOfMaximumSize()
        {
            int x = maximumNumberOfCitizens / 2;
            if (m_NumberOfCurrentCitizens  >= x)
            {
                return true;
            }
            return false;
        }
        public void PrintID()
        {
            Console.WriteLine(this.m_ID);
        }
        public void PrintGapBetweenMyIDAndFather()
        {
            int gap = m_fatherID - m_ID;
            Console.WriteLine(gap);
        }
        public void SetChildren(Citizen[] citizen)
        {
            this.children = citizen;
        }
        public override string ToString()
        {
            return $"[{base.ToString()}] Name: {m_name} Children :{children} MyID : {m_ID}\n" +
                $"MyFatherID:{m_fatherID} NumberOfCurrentCitizens : {m_NumberOfCurrentCitizens }";


        }
    }
}
