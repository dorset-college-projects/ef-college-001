using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDotNet001.models
{
    public partial class Enrolment
    {
        public int Id { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public Nullable<int> Grade { get; set; }

        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }


    }
}
