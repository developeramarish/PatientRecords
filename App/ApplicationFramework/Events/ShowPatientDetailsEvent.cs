﻿using System;

namespace PatientRecords.ApplicationFramework.Events
{
    public class ShowPatientDetailsEvent
    {
        public Guid PatientId { get; set; }

        public ShowPatientDetailsEvent(Guid id)
        {
            PatientId = id;
        }
    }
}