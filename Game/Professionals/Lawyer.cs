using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * when die add +2/+2 to random friend
 */

namespace SuperAutoProfessionals;

public class Lawyer : Professional
{
    public override string CodeName => "Lw";

    int health;
    int attack;

    internal override bool On(Event e)
    {
        base.On(e);

       

        var p = e.Professional!;
        

        if (e.Code != EventCode.Die || p != this) return false;


       
            //get location, full health 
            var pos = p.Index;
            var startHealth = p.Health;
            var startAttack = p.Attack;

            //spawn back at location and full health 
            var myself = new Lawyer
            {
                Attack = startAttack,
                Health = startHealth
            };

            Log($"Spawning {p}");
            Game.Spwan(p.Team, myself, pos);


        
        return true;
    }
}

 

