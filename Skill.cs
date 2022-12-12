using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWar
{
    internal class Ability
    {
        public string Id { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
        public string Dimension { get; set; } = string.Empty;

        public bool isAbilityOperated = false;

        public string Effect { get; set; } = string.Empty;
        public Ability() { }
    }

    internal class Effect
    {
        public string EffectName { get; set; } = string.Empty;
        public string EffectRange { get; set; } = string.Empty;
        public int EffectRate { get; set; } = 0;
        public int Portion { get; set; } = 0;
        public string Type { get; set; } = string.Empty;
        public string Describe { get; set; } = string.Empty;
        public Effect() { }
        
    }

    internal class Skill
    {
        public string Name { get; set; } = string.Empty;
        public string Id { get; set; } = string.Empty;
        public string Describe { get; set; } = string.Empty;
        public string RangeSkill { get; set; } = string.Empty;
        public float Amout { get; set; } = 0;
        public int CountDown { get; set; } = 0;
        public string Kind { get; set; } = string.Empty;
        public string Element { get; set; } = string.Empty;
        public List<Effect> Effects { get; set; } = new List<Effect>();
        public Skill() { }

        public static (float, string) DamageCalculation(Pokemon user, string useSkill, Pokemon target)
        {
            float damage = 0;
            string notion = "none";
            foreach (Skill skill in user.Skills)
            {
                if (useSkill == skill.Name)
                {
                    if (skill.Kind == "Status") return (-1, notion);
                    int userDamage = 0, targetDef = 0;
                    if (skill.Kind == "Physical")
                    {
                        userDamage = user.Atk;
                        targetDef = target.Def;
                    } else if (skill.Kind == "Special")
                    {
                        userDamage = user.SpAtk;
                        targetDef = target.SpDef;
                    }
                    Effect effect = skill.Effects.FirstOrDefault(e=>e.EffectName=="Ignore Defense");
                    if (effect != null)
                        targetDef = targetDef/2;
                    //main calculation
                    float ExpDamage = (float)0.5;
                    damage += (ExpDamage * skill.Amout * ((float)userDamage / (float)targetDef))/2 + (float)2;
                    //calculate stab of element SKILL<->TARGET
                    (float,string) result = Game.ElementStab(target, skill);
                    damage *= result.Item1;
                    notion = result.Item2;
                    //calculate stab of element SKILL<->USER
                    if (Game.isSkillSameType(user, skill))
                    {
                        if (user.ability.Name == "Up Element") damage *= (float)2;
                        else damage *= (float)1.5;
                    }
                    //calculate benefical effect
                    if (user.ability.Name== "Berserk") damage *= (float)1.3;
                }
            }
            return (damage, notion);
        }
    }
}
