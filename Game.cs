using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PokeWar
{
    
    internal class Game
    {
        public Game() { }
        public static bool GetChance(int percentage)
        {
            if (percentage<0 || percentage>100) return false;
            Random rnd = new Random();
            int value = rnd.Next(101);
            if (value <= percentage) return true;
            else return false;
        }
        public static float GetPercentage(int percentage, int value)
        {
            return ((float)percentage*100)/(float)value;
        }

        public static bool isSkillSameType(Pokemon user, Skill skill)
        {
            foreach ((string Name, string) element in user.Element)
            {
                if (element.Name == skill.Element) return true;
            }
            return false;
        }
        public static (float, string) ElementStab(Pokemon target, Skill skill)
        {
            TypeChart tc = new TypeChart();
            float bonus = 1;
            Console.WriteLine("Element of Skill is " + skill.Element);
            for (int i = 0; i < tc.length; i++)
            {
                if (tc.chart[i, 0] == skill.Element)
                {
                    for (int j = 0; j < tc.length; j++)
                    {
                        foreach ((string Name,string) ele in target.Element)
                        {
                            Console.WriteLine("Element of Pokemon is " + ele);
                            if (ele.Name == tc.chart[0, j]) bonus *= float.Parse(tc.chart[i, j]);
                        }
                    }
                }
            }
            string notion = "Normal";
            if (bonus < 1) notion = "Not too Effective";
            else if (bonus == 2) notion = "Super Effective";
            else if (bonus == 4) notion = "Extremely Effective";
            else if (bonus == 0) notion = "Not affacted";

            return (bonus, notion);
        }
    }   

    internal class TypeChart
    {
        public const int totalElement = 19;
        public int length = totalElement;
        public string[,] chart; 
        public TypeChart() {
            this.chart = new string[totalElement, totalElement] {
                {"none", "NOR", "FIR", "WAT", "GRS", "ELE", "ICE", "FIG", "PSN", "GRD", "FLY", "PSY", "BUG", "ROC", "GST", "DRG", "DAR", "STL", "FAR"},
                {"NOR" , "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0.5", "0", "1", "1", "0.5", "1"},
                {"FIR" , "1", "0.5", "0.5", "2", "1", "2", "1", "1", "1", "1", "1", "2", "0.5", "1", "0.5", "1", "2", "1"},
                {"WAT" , "1", "2", "0.5", "0.5", "1", "1", "1", "1", "2", "1", "1", "1", "2", "1", "0.5", "1", "1", "1"},
                {"GRS" , "1", "0.5", "2", "0.5", "1", "1", "1", "0.5", "2", "0.5", "1", "0.5", "2", "1", "0.5", "1", "0.5", "1"},
                {"ELE" , "1", "1", "2", "0.5", "0,5", "1", "1", "1", "0", "2", "1", "1", "1", "1", "0.5", "1", "1", "1"},
                {"ICE" , "1", "0.5", "0.5", "2", "1", "0.5", "1", "1", "2", "2", "1", "1", "1", "1", "2", "1", "0.5", "1"},
                {"FIG" , "2", "1", "1", "1", "1", "2", "1", "0.5", "1", "0.5", "0.5", "0.5", "2", "0", "1", "2", "2", "0.5"},
                {"PSN" , "1", "1", "1", "2", "1", "1", "1", "0.5", "0.5", "1", "1", "1", "0.5", "0.5", "1", "1", "0", "2"},
                {"GRD" , "1", "2", "1", "0.5", "2", "1", "1", "2", "1", "0", "1", "0.5", "2", "1", "1", "1", "2", "1"},
                {"FLY" , "1", "1", "1", "2", "0.5", "1", "2", "1", "1", "1", "1", "2", "0.5", "1", "1", "1", "0.5", "1"},
                {"PSY" , "1", "1", "1", "1", "1", "1", "2", "2", "1", "1", "0.5", "1", "1", "1", "1", "0", "0.5", "1"},
                {"BUG" , "1", "0.5", "1", "2", "1", "1", "0.5", "0.5", "1", "0.5", "2", "1", "1", "0.5", "1", "2", "0.5", "0.5"},
                {"ROC" , "1", "2", "1", "1", "1", "2", "0.5", "1", "0.5", "2", "1", "2", "1", "1", "1", "1", "0.5", "1"},
                {"GST" , "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "2", "1", "1", "2", "1", "0.5", "1", "1"},
                {"DRG" , "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "2", "1", "0.5", "0"},
                {"DAR" , "1", "1", "1", "1", "1", "1", "0.5", "1", "1", "1", "2", "1", "1", "2", "1", "0.5", "1", "0.5"},
                {"STL" , "1", "0.5", "0.5", "1", "0.5", "2", "1", "1", "1", "1", "1", "1", "2", "1", "1", "1", "0.5", "2"},
                {"FAR" , "1", "0.5", "1", "1", "1", "1", "2", "0.5", "1", "1", "1", "1", "1", "1", "2", "2", "0.5", "1"}
            };
        }
    }
}


