﻿using System.Collections.Generic;

namespace SharpIpp.Model
{
    public class PrintUriResponse : IIppJobResponse
    {
        public IppVersion Version { get; set; } = IppVersion.V11;
        public IppStatusCode StatusCode { get; set; }
        public int RequestId { get; set; } = 1;
        public string JobUri { get; set; } = null!;
        public int JobId { get; set; }
        public JobState JobState { get; set; }
        public string[] JobStateReasons { get; set; } = null!;
        public string? JobStateMessage { get; set; }
        public int? NumberOfInterveningJobs { get; set; }
        public List<IppSection> Sections { get; } = new List<IppSection>();
    }
}