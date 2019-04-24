namespace P08.MilitaryElite.Contracts.Privates.SpecialisedSoldiers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

   public interface IMission
    {
        string CodeName { get; }

        string State { get; }
    }
}
