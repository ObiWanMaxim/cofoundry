﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofoundry.Domain
{
    public class CustomEntityUnPublishedMessage : ICustomEntityContentUpdatedMessage
    {
        /// <summary>
        /// Id of the custom entity that the content change affects
        /// </summary>
        public int CustomEntityId { get; set; }

        /// <summary>
        /// Definition code of the custom entity that the content change affects
        /// </summary>
        public string CustomEntityDefinitionCode { get; set; }

        public bool HasPublishedVersionChanged { get { return true; } }
    }
}