using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoftwareTesting_UAS
{
    internal class Agent
    {
        //public prefab Projectile_Prefab;
        public Agent(string label, string name, int maximumHealthPoint, int currentHealthPoint, int attackPoint)
        {
            Label = label;
            Name = name;
            MaximumHealthPoint = maximumHealthPoint;
            CurrentHealthPoint = currentHealthPoint;
            AttackPoint = attackPoint;
        }

        public string Label {get; set;}
        public string Name { get; set; }
        public int MaximumHealthPoint { get; set; }
        public int CurrentHealthPoint { get; set; }
        public int AttackPoint { get; set; }
        
        public int Ability1(Agent collidingAgent)//400 (+60% Total Attack Point) (+target's 30% Lost HP) true damage. If boss, max = 2500
        {
            int baseDamage = 400;
            int percentageBasedDamage = (int)(0.3 * collidingAgent.MaximumHealthPoint - CurrentHealthPoint);
            int attackPointDamage = (int)(0.6 * AttackPoint);
            int total = baseDamage + percentageBasedDamage + attackPointDamage;

            if (collidingAgent.Label == "Boss")
            {
                return Math.Min(2500, total);
            }
            else
            {
               return total;
            }
        }
    }
}
