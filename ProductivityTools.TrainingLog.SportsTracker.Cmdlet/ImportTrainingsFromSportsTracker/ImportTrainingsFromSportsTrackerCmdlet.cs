﻿using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;

namespace ProductivityTools.TrainingLog.SportsTracker.ImportTrainingsFromSportsTracker
{
    [Cmdlet("Import", "TrainingsFromSportTracker")]
    class ImportTrainingsFromSportsTrackerCmdlet : ProductivityTools.PSCmdlet.PSCmdletPT
    {
        protected override void ProcessRecord()
        {
            WriteVerbose("Hello from Import-TrainingsToSportTracker");
            base.ProcessRecord();
        }
    }
}
