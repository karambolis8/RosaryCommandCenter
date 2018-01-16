using System.Collections.Generic;

namespace RosaryGroupDomain.DomainModels
{
    class RosaryGroup
    {
        public RosaryGroup()
        {
            Members = new List<RosaryMember>();
        }

        public IList<RosaryMember> Members { get; set; }
    }
}
