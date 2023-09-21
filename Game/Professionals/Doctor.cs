using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * when hurt can heal myself for +2
 */
namespace SuperAutoProfessionals;

public class Doctor : Professional
{
    public override string CodeName => "Dc";
    private int counter = 0;
    internal override bool On(Event e)
    {
        base.On(e);


        var p = e.Professional!;
        //if its not this professional or the professional is dead
        if (p != this || p.IsDead) return false;

        //heal after hurt
        if (e.Code == EventCode.Hurt)
        {
            Log($"Healing itself {p}");
            p.Health += 2;
            counter++;
        }


        return true;
    }
}


