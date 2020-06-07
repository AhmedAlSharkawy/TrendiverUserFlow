using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommingSoon.Models
{
    public class ContentPublisherInfoDTO
    {

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string ContentType { get; set; }
        public int? ContentNumber { get; set; }
        public int? PriceAvg { get; set; }
        public int ViewwesAvg { get; set; }
    }

    public class GroupingContentPublisher {
        public List<ContentPublisherInfoDTO> GroupingData { get; set; }
        public string ContentType { get; set; }
        public long Count { get; set; }
    }

    public class DashBoard {
        public List<ContentPublisherInfoDTO> ContentPublishers_All { get; set; }
        public long ContentPublisher_All_Count { get; set; }
        public List<ContentPublisherInfoDTO> ContentPublishers_Today { get; set; }
        public long ContentPublisher_Today_Count { get; set; }
        public List<GroupingContentPublisher> GroupingContentPublishers_All { get; set; }
        public List<GroupingContentPublisher> GroupingContentPublishers_Today { get; set; }
        public int ContentProviders { get; set; }
        public int Contents { get; set; }
        public int AvgPricePerContent  { get; set; }
        public int AvgEstimatedViewersPerContent { get; set; }
        public int TotalEstimatedRevenue { get; set; }
        public int CommissionNet { get; set; }
    }
}