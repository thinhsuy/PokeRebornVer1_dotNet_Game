using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PokeWar
{
    internal class Pokemon
    {
        public string Name = "";
        public string Id = "";
        public string CurrentTeam = String.Empty;   
        public int HP = 0;
        public int Atk = 0;
        public int Def = 0;
        public int SpAtk = 0;
        public int SpDef = 0;
        public int Speed = 0;

        public Ability ability = new Ability();

        public
            Dictionary<string, string> Sources = new Dictionary<string, string>();
        public
            List<(string Id, string Src)> Element = new List<(string element, string source)>();
        public
            List<Skill> Skills = new List<Skill>();
        public
            List<string> HarmfulEffect = new List<string>();
        public    
            List<string> BeneficalEffect = new List<string>();

        public Pokemon(string pokeId)
        {
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;

            this.Id = pokeId;
            Read_Information(pokeId, cnn);
            Read_Element(pokeId, cnn);
            Read_Skills(pokeId, cnn);
            Read_Effect(cnn);
            Read_Ability(cnn, pokeId);



            DBC.CloseDB(cnn);
        }
        private void Read_Information(string pokeId, SqlConnection cnn)
        {
            string sql = "", str = "";
            try
            {
                sql = "select top(1) p.Name, pi.HP, pi.Attack, pi.Defense, pi.SpecialAttack, pi.SpecialDefense, pi.Speed, ps.ImgSrc, es.Based";
                sql += " from Pokemon as p inner join PokeInfor as pi on p.pokeId=pi.pokeId and p.pokeId='" + pokeId + "'";
                sql += " inner join PokeSource as ps on ps.pokeId=p.pokeId";
                sql += " inner join PokeType as pt on pt.pokeId=p.pokeId";
                sql += " inner join ElementSource as es on es.eleId=pt.eleId";
                str = DBC.ReadInforFromDB(sql, cnn, 9);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(DBC.CatchSqlExeption(ex));
            }


            var result = str.Split('\n');
            this.Name = result[0];
            this.HP = int.Parse(result[1])*2;
            this.Atk = int.Parse(result[2]);
            this.Def = int.Parse(result[3]);
            this.SpAtk = int.Parse(result[4]);
            this.SpDef = int.Parse(result[5]);
            this.Speed = int.Parse(result[6]);

            string path = result[7];
            Sources.Add("Front", path + "Front.gif");
            Sources.Add("Back", path + "Back.gif");
            Sources.Add("Based", result[8]);
            try
            {
                Sources.Add("SkillA", path + "A.png");
                Sources.Add("SkillB", path + "B.png");
                Sources.Add("SkillC", path + "C.png");
                Sources.Add("Attack", path + "Attack.gif");
                Sources.Add("Status", path + "Status.gif");
            }
            catch (Exception ex)
            {
                Sources.Add("Attack", path + "Front.gif");
                Sources.Add("Status", path + "Front.gif");
            }
        }
        private void Read_Element(string pokeId, SqlConnection cnn)
        {
            int col = 2;
            string sql = "select pt.eleId, es.ImgSrc from PokeType as pt inner join Pokemon as p on p.pokeId=pt.pokeId and p.pokeId='" + pokeId + "'";
            sql += " inner join ElementSource as es on es.eleId=pt.eleId";
            string str = DBC.ReadInforFromDB(sql, cnn, 2);
            var result = str.Split('\n');
            for (int i = 0; i < result.Length-1; i += col)
            {
                (string Name, string Src) temp = (result[i], result[i + 1]);
                Element.Add(temp);
            }
        }
        private void Read_Skills(string pokeId, SqlConnection cnn)
        {
            int col = 8;
            string sql = "select s.skillId, s.Name, s.Explain, si.Range, si.Damage, si.CountDown, s.Kind, s.eleId";
            sql += " from PokeSkill as ps inner join Skill as s on ps.skillId=s.skillId and ps.pokeId='" + pokeId + "'";
            sql += " inner join SKillInfor as si on si.skillId=s.skillId";
            
            string str = DBC.ReadInforFromDB(sql, cnn, col);
            var result = str.Split('\n');
            for (int i = 0, j = 0; i < 3; i++, j += col)
            {
                Skill skill = new Skill();
                skill.Id = result[j];
                skill.Name = result[j + 1];
                skill.Describe = result[j + 2];
                skill.RangeSkill = result[j + 3];
                skill.Amout = int.Parse(result[j + 4]);
                skill.CountDown = int.Parse(result[j + 5]);
                skill.Kind = result[j + 6];
                skill.Element = result[j + 7];
                Skills.Add(skill);
            }
        }
        private void Read_Effect(SqlConnection cnn)
        {
            foreach (Skill skill in Skills)
            {
                int col = 5;
                string sql = "select se.Effect, se.Range, se.Rate, e.Describe, e.TypeEffect";
                sql += " from SkillEffect as se inner join Effect as e on e.effectName=se.Effect and se.skillId='" + skill.Id + "'";
                string str = DBC.ReadInforFromDB(sql, cnn, col);
                var result = str.Split('\n');
                for (int i = 0; i < result.Length-1; i += col)
                {
                    Effect eff = new Effect();
                    eff.EffectName = result[i];
                    eff.EffectRange = result[i + 1];
                    eff.EffectRate = int.Parse(result[i + 2]);
                    eff.Describe = result[i + 3];
                    eff.Type = result[i + 4];

                    if (eff.EffectName == "Heal")
                        eff.Portion = (int)skill.Amout;
                    skill.Effects.Add(eff);
                }
            }
        }

        private void Read_Ability(SqlConnection cnn, string pokeId)
        {
            int col = 4;
            string sql = "select a.AbilityName, a.Dimension, a.abiId, ae.Effect";
            sql += " from PokeAbility as pa inner join Ability as a on pa.abiId = a.abiId and pa.pokeId='" + pokeId + "'";
            sql += " inner join AbilityEffect as ae on ae.abiId=a.abiId";
            string str = DBC.ReadInforFromDB(sql, cnn, col);
            var result = str.Split('\n');
            for (int i = 0; i < result.Length-1; i+=col)
            {
                ability.Name = result[i];
                ability.Dimension = result[i + 1];
                ability.Id = result[i + 2];
                ability.Effect = result[i + 3];
            }
        }
    }
}
