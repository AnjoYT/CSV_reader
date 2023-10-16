using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSV_reader
{
	internal class CSV_model
	{
		public string Name { get; set; }
		public string NameOfProcedure { get; set; }
		public string Priority { get; set; }
		public DateTime? OrderDate { get; set; }
		public DateTime ExecutionDate { get; set; }
		public DateTime? ResultDate { get; set; }
		public string? Status { get; set; }
		public DateTime? HigOrderDate { get; set; }
		public string Facility { get; set; }
		public string OrderingDoctor { get; set; }
		public DateTime? ExecutingDoctor { get; set; }
		public string? StudyId { get; set; }
		public string? PatientId { get; set; }
	}
}
