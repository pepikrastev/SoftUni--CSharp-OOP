namespace P08.MilitaryElite.Models.Privates.SpecialisedSoldiers
{
    using P08.MilitaryElite.Contracts.Privates.SpecialisedSoldiers;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary, string corps, IReadOnlyCollection<Mission> missions)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = missions;
        }

        public IReadOnlyCollection<Mission> Missions { get; }


        public void CompleteMission(string codeName)
        {
            Mission mission = Missions.FirstOrDefault(x => x.CodeName == codeName);

            if (mission != null)
            {
                mission.State = "Complete";
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            sb.AppendLine("Missions:");

            foreach (var mission in this.Missions.OrderByDescending(x => x.CodeName))
            {
                sb.AppendLine("  " + mission.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
