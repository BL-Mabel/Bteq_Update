using System;
using System.Collections.Generic;
using System.Text;

namespace RepoLayer
{
    public class GetAllCampaignResponse
    {
        public List<CampaignEntity> Campaigns { get; set; }
        public int CampaignCount { get; set; }
    }
}
