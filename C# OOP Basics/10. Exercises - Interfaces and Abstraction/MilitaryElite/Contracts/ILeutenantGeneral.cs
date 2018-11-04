namespace MilitaryElite.Contracts
{
    using System.Collections.Generic;

    public interface ILeutenantGeneral : IPrivate
    {
        ICollection<IPrivate> Privates { get; set; }
    }
}