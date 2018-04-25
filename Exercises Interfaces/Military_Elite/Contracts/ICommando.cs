using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Contracts
{
    interface ICommando : ISpecializedSoldier
    {
		IReadOnlyCollection<IMission> Missions { get; }
		void CompleteMission(string missionCodeName);
    }
}
