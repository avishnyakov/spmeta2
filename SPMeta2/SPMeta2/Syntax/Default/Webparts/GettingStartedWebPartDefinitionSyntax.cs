using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using SPMeta2.Definitions.Webparts;
using SPMeta2.Models;

namespace SPMeta2.Syntax.Default
{

    [Serializable]
    [DataContract]
    public class GettingStartedWebPartModelNode : WebPartModelNode
    {

    }

    public static class GettingStartedWebPartDefinitionSyntax
    {
        #region methods

        public static TModelNode AddGettingStartedWebPart<TModelNode>(this TModelNode model, GettingStartedWebPartDefinition definition)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return AddGettingStartedWebPart(model, definition, null);
        }

        public static TModelNode AddGettingStartedWebPart<TModelNode>(this TModelNode model, GettingStartedWebPartDefinition definition,
            Action<GettingStartedWebPartModelNode> action)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion

        #region array overload

        public static TModelNode AddGettingStartedWebParts<TModelNode>(this TModelNode model, IEnumerable<GettingStartedWebPartDefinition> definitions)
           where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            foreach (var definition in definitions)
                model.AddDefinitionNode(definition);

            return model;
        }

        #endregion
    }
}
