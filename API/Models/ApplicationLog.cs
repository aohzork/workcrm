﻿using Microsoft.Identity.Client;

namespace API.Models
{
    public class ApplicationLog
    {
        public int Id { get; set; }
        public int JobApplicationId { get; set; }
        public JobApplication JobApplication { get; set; }
        public string Message { get; set; }
        public DateTime? Date { get; set; }
    }
}
