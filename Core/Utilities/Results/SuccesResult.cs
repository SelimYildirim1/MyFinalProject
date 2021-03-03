using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class SuccesResult:Result
    {
        //utilities:Araçlar
        public SuccesResult(string massage) : base(true, massage)
        {

        }

        public SuccesResult() : base(true)
        {

        }
    }
}
