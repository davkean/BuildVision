﻿using BuildVision.Common;
using BuildVision.Contracts;
namespace BuildVision.UI.Settings.Models
{
    public class ProjectItemSettings : SettingsBase
    {
        public BuildOutputFileTypes CopyBuildOutputFileTypesToClipboard { get; set; }

        public ProjectItemSettings()
        {
            CopyBuildOutputFileTypesToClipboard = new BuildOutputFileTypes();
        }
    }
}
