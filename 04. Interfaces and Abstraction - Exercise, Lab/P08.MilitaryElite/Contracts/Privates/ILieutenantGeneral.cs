namespace P08.MilitaryElite.Contracts.Privates
{
    using P08.MilitaryElite.Models;
    using System;
    using System.Collections.Generic;

    public interface ILieutenantGeneral
    {
        IReadOnlyCollection<Private> Privates { get; }
    }
}
