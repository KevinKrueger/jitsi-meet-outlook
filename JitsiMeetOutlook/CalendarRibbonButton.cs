﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace JitsiMeetOutlook
{
    public partial class CalendarRibbonButton
    {
        private void CalendarRibbonButton_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void buttonNewJitsiMeeting_Click(object sender, RibbonControlEventArgs e)
        {
            new NewJitsiAppointment();
        }
    }
}