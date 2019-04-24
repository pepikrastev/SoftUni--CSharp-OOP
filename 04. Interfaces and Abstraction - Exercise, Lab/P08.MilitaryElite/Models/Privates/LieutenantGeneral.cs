namespace P08.MilitaryElite.Models.Privates
{
    using P08.MilitaryElite.Contracts.Privates;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary, IReadOnlyCollection<Private> privates) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates = privates;    
        }

        public IReadOnlyCollection<Private> Privates { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");

            foreach (var @private in this.Privates.OrderByDescending(x => x.Id))
            {
                sb.AppendLine("  " + @private.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
