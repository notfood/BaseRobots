using System;
using System.Collections.Generic;
using Verse;

namespace BaseRobot
{
	public class BaseRobot_disabled : ThingWithComps
	{
        
		//
		// Fields
		//
		public Building_BaseRobotRechargeStation rechargestation;
        
        public override IEnumerable<Thing> ButcherProducts(Pawn butcher, float efficiency)
        {
            return new List<Thing>();
        }

    }
}
