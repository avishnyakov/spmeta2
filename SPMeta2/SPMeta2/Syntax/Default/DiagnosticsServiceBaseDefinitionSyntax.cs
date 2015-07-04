﻿using SPMeta2.Definitions;
using SPMeta2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SPMeta2.Models;
using SPMeta2.Syntax.Default.Extensions;

namespace SPMeta2.Syntax.Default
{
    public class DiagnosticsServiceBaseModelNode : ListItemModelNode
    {

    }

    public static class DiagnosticsServiceBaseDefinitionSyntax
    {
        #region methods

        public static FarmModelNode AddDiagnosticsServiceBase(this FarmModelNode model, DiagnosticsServiceBaseDefinition definition)
        {
            return AddDiagnosticsServiceBase(model, definition, null);
        }

        public static FarmModelNode AddDiagnosticsServiceBase(this FarmModelNode model, DiagnosticsServiceBaseDefinition definition, Action<ModelNode> action)
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion
    }
}