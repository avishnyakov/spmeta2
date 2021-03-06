using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using SPMeta2.Definitions.Webparts;
using SPMeta2.Models;
using SPMeta2.Standard.Definitions.Webparts;
using SPMeta2.Syntax.Default;

namespace SPMeta2.Standard.Syntax
{

    [Serializable]
    [DataContract]
    public class RSSAggregatorWebPartModelNode : WebPartModelNode
    {

    }

    public static class RSSAggregatorWebPartDefinitionSyntax
    {
        #region methods

        public static TModelNode AddRSSAggregatorWebPart<TModelNode>(this TModelNode model, RSSAggregatorWebPartDefinition definition)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return AddRSSAggregatorWebPart(model, definition, null);
        }

        public static TModelNode AddRSSAggregatorWebPart<TModelNode>(this TModelNode model, RSSAggregatorWebPartDefinition definition,
            Action<RSSAggregatorWebPartModelNode> action)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion

        #region array overload

        public static TModelNode AddRSSAggregatorWebParts<TModelNode>(this TModelNode model, IEnumerable<RSSAggregatorWebPartDefinition> definitions)
           where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            foreach (var definition in definitions)
                model.AddDefinitionNode(definition);

            return model;
        }

        #endregion
    }
}
