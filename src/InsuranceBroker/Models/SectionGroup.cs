using System.Collections.Generic;

namespace InsuranceBroker.Models
{
    public class SectionGroup
    {
        public SectionGroup(List<Section> sections)
        {
            Sections = sections;
        }

        public SectionGroup()
        {
        }

        public bool Used { get; set; }
        public List<Section> Sections { get; set; }
    }
}