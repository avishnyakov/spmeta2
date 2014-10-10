﻿using SPMeta2.CSOM.ModelHandlers.ContentTypes;
using SPMeta2.Definitions;
using SPMeta2.Definitions.ContentTypes;
using SPMeta2.Utils;

namespace SPMeta2.Regression.CSOM.Validation.ContentTypes
{
    public class RemoveContentTypeFieldLinksDefinitionValidator : RemoveContentTypeFieldLinksModelHandler
    {
        public override void DeployModel(object modelHost, DefinitionBase model)
        {
            var definition = model.WithAssertAndCast<RemoveContentTypeFieldLinksDefinition>("model", value => value.RequireNotNull());
            var spObject = ExtractContentTypeFromHost(modelHost);

            ServiceFactory.AssertService
                           .NewAssert(definition, spObject)
                                 .ShouldNotBeNull(spObject);
        }
    }
}
