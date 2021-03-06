﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using SPMeta2.Attributes;
using SPMeta2.Attributes.Capabilities;
using SPMeta2.Attributes.Identity;
using SPMeta2.Attributes.Regression;
using SPMeta2.Utils;

namespace SPMeta2.Definitions.ContentTypes
{
    /// <summary>
    /// Allows to remove fields from the particular content type.
    /// </summary>
    [SPObjectType(SPObjectModelType.SSOM, "Microsoft.SharePoint.SPContentType", "Microsoft.SharePoint")]
    [SPObjectType(SPObjectModelType.CSOM, "Microsoft.SharePoint.Client.ContentType", "Microsoft.SharePoint.Client")]

    [DefaultRootHost(typeof(SiteDefinition))]
    [DefaultParentHost(typeof(ContentTypeDefinition))]

    [Serializable] 
    [DataContract]

    [ParentHostCapability(typeof(ContentTypeDefinition))]
    public class RemoveContentTypeFieldLinksDefinition : DefinitionBase
    {
        #region constructors

        public RemoveContentTypeFieldLinksDefinition()
        {
            Fields = new List<FieldLinkValue>();
        }

        #endregion

        #region properties

        [DataMember]
        [IdentityKey]
        public List<FieldLinkValue> Fields { get; set; }

        #endregion

        #region methods

        public override string ToString()
        {
            return new ToStringResult<RemoveContentTypeFieldLinksDefinition>(this)
                          .AddPropertyValue(p => p.Fields)
                          .ToString();
        }

        #endregion
    }
}
