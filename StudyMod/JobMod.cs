using System;
using System.Collections.Generic;
using System.Text;

namespace StudyMod
{
    public class JobMod
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public string JobName { get; set; }
        public int Level { get; set; }
        public List<JobMod> SubList { get; set; }
        public JobMod FMod { get; set; }

        public JobMod()
        {
            SubList = new List<JobMod>();

        }
    }
}
