using System.Collections.Generic;

namespace RosaryWPFWindows.Models
{
    class RosaryGroupModel
    {
        public RosaryGroupModel()
        {
            Members = new List<RosaryMemberModel>();
        }

        public IList<RosaryMemberModel> Members { get; set; }
    }
}
