﻿using MongoDB.Bson;

namespace TMTDemoMongDb.Models
{
    public class Employee
    {
        public ObjectId Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string PhotoFileName { get; set; }

    }
}
