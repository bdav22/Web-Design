using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * before attack gets +5 health (two times)
 */
namespace SuperAutoProfessionals;

public class Chef : Professional
{
    public override string CodeName => "Ch";
    private int counter = 0;
    internal override bool On(Event e)
    {
        base.On(e);

        
        var p = e.Professional!;
        //if its not this professional or the professional is dead
        if (p != this || p.IsDead) return false;

        //heal before attack
        if ((e.Code == EventCode.BeforeAttack && counter < 2)) {
            Log($"Healing {p}");
            p.Health += 5;
            counter++;
        }


        return true;
    }
}


