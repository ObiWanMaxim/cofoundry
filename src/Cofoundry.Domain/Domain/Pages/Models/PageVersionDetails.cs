﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofoundry.Domain
{
    public class PageVersionDetails : ICreateAudited
    {
        public int PageVersionId { get; set; }

        public string Title { get; set; }

        /// <summary>
        /// Indicates whether the page should show in the autogenerated site map
        /// that gets presented to search engine robots.
        /// </summary>
        public bool ShowInSiteMap { get; set; }
        
        public PageMetaData MetaData { get; set; }

        public OpenGraphData OpenGraph { get; set; }

        public WorkFlowStatus WorkFlowStatus { get; set; }

        public PageTemplateMicroSummary Template { get; set; }

        public CreateAuditData AuditData { get; set; }
    }
}