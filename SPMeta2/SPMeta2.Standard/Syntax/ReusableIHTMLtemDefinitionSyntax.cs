﻿using System;
using System.Collections.Generic;
using SPMeta2.Models;
using SPMeta2.Standard.Definitions;
using SPMeta2.Standard.Definitions.Webparts;
using SPMeta2.Syntax.Default;
using SPMeta2.Syntax.Default.Extensions;

namespace SPMeta2.Standard.Syntax
{
    public class ReusableHTMLItemModelNode : ListItemModelNode
    {

    }

    public class ReusableTextItemModelNode : ListItemModelNode
    {

    }

    public static class ReusableHTMLItemDefinitionSyntax
    {
        #region html

        public static ListModelNode AddReusableHTMLItem(this ListModelNode model, ReusableHTMLItemDefinition definition)
        {
            return AddReusableHTMLItem(model, definition, null);
        }

        public static ListModelNode AddReusableHTMLItem(this ListModelNode model, ReusableHTMLItemDefinition definition, Action<ModelNode> action)
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        public static FolderModelNode AddReusableHTMLItem(this FolderModelNode model, ReusableHTMLItemDefinition definition)
        {
            return AddReusableHTMLItem(model, definition, null);
        }

        public static FolderModelNode AddReusableHTMLItem(this FolderModelNode model, ReusableHTMLItemDefinition definition, Action<ModelNode> action)
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion

        #region array overload

        public static ModelNode AddReusableHTMLItems(this ModelNode model, IEnumerable<ReusableHTMLItemDefinition> definitions)
        {
            foreach (var definition in definitions)
                model.AddDefinitionNode(definition);

            return model;
        }

        #endregion

        #region text

        public static ListModelNode AddReusableTextItem(this ListModelNode model, ReusableTextItemDefinition definition)
        {
            return AddReusableTextItem(model, definition, null);
        }

        public static ListModelNode AddReusableTextItem(this ListModelNode model, ReusableTextItemDefinition definition, Action<ModelNode> action)
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        public static FolderModelNode AddReusableTextItem(this FolderModelNode model, ReusableTextItemDefinition definition)
        {
            return AddReusableTextItem(model, definition, null);
        }

        public static FolderModelNode AddReusableTextItem(this FolderModelNode model, ReusableTextItemDefinition definition, Action<ModelNode> action)
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion

        #region array overload

        public static ModelNode AddReusableTextItems(this ModelNode model, IEnumerable<ReusableTextItemDefinition> definitions)
        {
            foreach (var definition in definitions)
                model.AddDefinitionNode(definition);

            return model;
        }

        #endregion
    }
}