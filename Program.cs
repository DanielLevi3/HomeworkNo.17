using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17._07._20
{
    class Program
    {

        static void Main(string[] args)
        {
            Citizen Bob = new Citizen("Robert",1324);
            Citizen Josh = new Citizen("Josh", 0);
            Citizen Rob = new Citizen("Rob", 0);
            Citizen Kori = new Citizen("Kori", 0);
            Citizen[] B = new Citizen[3] { Josh, Rob, Kori };
            Bob.SetChildren(B);
            Citizen.PrintNumberOfCitizens();
            CheckValidity(Bob);
        }
        static bool HasChildren(Citizen citizen)
        {
            if (citizen.children.Count() == 0)
                return false;
            return true;
        }
        static bool CheckValidity(Citizen citizen)//10 //3: true//0:3,Fid:10//1:4,Fid:8//
        {
            if (citizen.children.Count() >= 1)
            {
                for(int i = 0; citizen.children.Length>0;i++)
                {
                    if (citizen.children[i].m_fatherID == citizen.m_ID)
                        return true;
                }
            }    return false;
        }

    }
}
