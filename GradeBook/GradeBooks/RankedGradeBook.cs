using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook (string name, bool IsWeighted) : base (name, IsWeighted)
        {
            this.Type = Enums.GradeBookType.Ranked;
        }
    }
}
