﻿using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.DefaultLocations;
using Sdl.Desktop.IntegrationApi.Extensions;

namespace Sdl.Community.ApplyStudioProjectTemplate
{
    /// <summary>
    /// The ribbon group where we will put our icon
    /// </summary>
    [RibbonGroup("ApplyStudioProjectTemplateSimplifiedRibbonGroup", Name = "Apply Project Template Simplified")]
    [RibbonGroupLayout(LocationByType = typeof(StudioDefaultRibbonTabs.AddinsRibbonTabLocation))]
    public class ApplyStudioProjectTemplateRibbonGroup : AbstractRibbonGroup
    {
    }
}
