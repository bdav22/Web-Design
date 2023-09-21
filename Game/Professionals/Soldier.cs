using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * before attack gets +5 health (two times)
 */
namespace SuperAutoProfessionals;

public class Soldier : Professional
{
    public override string CodeName => "So";
    private int counter = 0;
    internal override bool On(Event e)
    {
        base.On(e);


        var p = e.Professional!;
        //if its not this professional or the professional is dead
        if (p != this || p.IsDead) return false;

        //gain attack after attack
        if (e.Code == EventCode.AfterAttack)
        {
            Log($"Gaining attack {p}");
            p.Attack += 5;
        }


        return true;
    }
}


