using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //utilities:Araçlar
    // Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; }

        string Massage { get; }


    }
}
