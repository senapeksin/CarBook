using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.SocialMediaResult
{
    public class GetSocialMediaQueryResult
    {
          public int SocialMediaID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}