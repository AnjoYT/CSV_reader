using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_reader
{
    internal class CSV_model_count
    {
        public string Name { get; set; }
        public string NameOfProcedure { get; set; }
        public string Priority { get; set; }
        public string? OrderDate { get; set; }
        public string ExecutionDate { get; set; }
        public string? ResultDate { get; set; }
        public string? Status { get; set; }
        public string? HigOrderDate { get; set; }
        public string Facility { get; set; }
        public string OrderingDoctor { get; set; }
        public string? ExecutingDoctor { get; set; }
        public string? StudyId { get; set; }
        public string? PatientId { get; set; }
        public string? Count { get; set; }
    }
}
