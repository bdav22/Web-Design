using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * when died spawn 2 +5/+5 friends
 */

namespace SuperAutoProfessionals;

public class Lawyer : Professional
{
    public override string CodeName => "Lw";

    internal override bool On(Event e)
    {
        base.On(e);

        if (e.Code != EventCode.Die) return false;

        var p = e.Professional!;
        if (p != this) return false;

        var pos = p.Index;
        var friend = new Professional
        {
            Attack = 5,
            Health = 5
        };

        var pos2 = p.Index + 1;
        var friend2 = new Professional
        {
            Attack = 5,
            Health = 5
        };

        Log($"Trying to spawn {friend} at {pos}");
        Game.Spwan(p.Team, friend, pos);
        Log($"Trying to spawn {friend2} at {pos2}");
        Game.Spwan(p.Team, friend2, pos2);
        return true;
    }
}