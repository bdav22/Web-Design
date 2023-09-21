﻿namespace SuperAutoProfessionals;

public class Nurse : Professional
{
	public override string CodeName => "Nu";

	internal override bool On(Event e)
	{
		base.On(e);

		if (e.Code != EventCode.Hurt) return false;


		var p = e.Professional!;

		//if its myself, if theyre dead, or its the enemy do not heal
		if (p == this || p.IsDead || IsEnemy(p)) return false;

		Log($"Healing {p}");
		p.Health += 3;

		return true;
	}
}
