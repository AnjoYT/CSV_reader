using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSV_reader
{
	internal class Reader
	{
        static Reader()
        {

        }
        public static void CSV_load(string FirstFileName,string SecondFileName,string path)
        {
			List<CSV_model> list = new List<CSV_model>();
			var config = new CsvConfiguration(CultureInfo.InvariantCulture)
			{
				Delimiter = ";",
				Quote = '"',
				TrimOptions = TrimOptions.InsideQuotes,
				
			};
			using (var writer = new StreamWriter(path + "\\file.csv"))
			using (var csv3 = new CsvWriter(writer, config))
			{
				using (var FirstExcelReader = new StreamReader(FirstFileName))
				using (var FirstExcelCsv = new CsvReader(FirstExcelReader, config))
				{
					int i = 0;
					ArrayList NotFound = new ArrayList();
					string FirstRecordNotFound = "";
					var FirstExcelRecords = FirstExcelCsv.GetRecords<CSV_model>();
					foreach (var FirstExcelRecord in FirstExcelRecords)
					{
						using (var SecondExcelReader = new StreamReader(SecondFileName))
						using (var SecondExcelCsv = new CsvReader(SecondExcelReader, config))
						{
							var SecondExcelRecords = SecondExcelCsv.GetRecords<CSV_model>();
							foreach (var SecondExcelRecord in SecondExcelRecords)
							{

								if (CompareStrings.Compare(FirstExcelRecord.Name, SecondExcelRecord.Name) && CompareStrings.Compare(FirstExcelRecord.NameOfProcedure, SecondExcelRecord.NameOfProcedure) && CompareStrings.Compare(FirstExcelRecord.ExecutionDate, SecondExcelRecord.ExecutionDate))
								{
									i++;
									FirstRecordNotFound = "";
									Console.WriteLine("i: " + i + "    " + FirstExcelRecord.Name + " " + FirstExcelRecord.NameOfProcedure + " " + FirstExcelRecord.ExecutionDate);
									Console.WriteLine("i: " + i + "    " + SecondExcelRecord.Name + " " + SecondExcelRecord.NameOfProcedure + " " + SecondExcelRecord.ExecutionDate);
									list.Add(new CSV_model {Name = SecondExcelRecord.Name,NameOfProcedure = SecondExcelRecord.NameOfProcedure, Priority = FirstExcelRecord.Priority, OrderDate = SecondExcelRecord.OrderDate, ExecutionDate = SecondExcelRecord.ExecutionDate, ResultDate = SecondExcelRecord.ResultDate, Status = SecondExcelRecord.Status, HigOrderDate = SecondExcelRecord.HigOrderDate, Facility = SecondExcelRecord.Facility, OrderingDoctor= SecondExcelRecord.OrderingDoctor, ExecutingDoctor = SecondExcelRecord.ExecutingDoctor, StudyId = SecondExcelRecord.StudyId, PatientId = SecondExcelRecord.PatientId });
									
									break;
								}
								else if (CompareStrings.Compare(FirstExcelRecord.Name, SecondExcelRecord.Name) && CompareStrings.Compare(FirstExcelRecord.NameOfProcedure, SecondExcelRecord.NameOfProcedure) && CompareStrings.Compare(FirstExcelRecord.OrderingDoctor, SecondExcelRecord.OrderingDoctor))
								{
									i++;
									FirstRecordNotFound = "";
									Console.WriteLine("[NOT ACCURATE] i: " + i + "    " + FirstExcelRecord.Name + " " + FirstExcelRecord.NameOfProcedure + " " + FirstExcelRecord.ExecutionDate);
									Console.WriteLine("[NOT ACCURATE] i: " + i + "    " + SecondExcelRecord.Name + " " + SecondExcelRecord.NameOfProcedure + " " + SecondExcelRecord.ExecutionDate);
									list.Add(new CSV_model { Name = SecondExcelRecord.Name, NameOfProcedure = SecondExcelRecord.NameOfProcedure, Priority = FirstExcelRecord.Priority, OrderDate = SecondExcelRecord.OrderDate, ExecutionDate = SecondExcelRecord.ExecutionDate, ResultDate = SecondExcelRecord.ResultDate, Status = SecondExcelRecord.Status, HigOrderDate = SecondExcelRecord.HigOrderDate, Facility = SecondExcelRecord.Facility, OrderingDoctor = SecondExcelRecord.OrderingDoctor, ExecutingDoctor = SecondExcelRecord.ExecutingDoctor, StudyId = SecondExcelRecord.StudyId, PatientId = SecondExcelRecord.PatientId });
									
									break;
								}
								else if (CompareStrings.Compare(FirstExcelRecord.Name, SecondExcelRecord.Name) && CompareStrings.CompareParentheses(FirstExcelRecord.NameOfProcedure, SecondExcelRecord.NameOfProcedure) && CompareStrings.Compare(FirstExcelRecord.ExecutionDate, SecondExcelRecord.ExecutionDate))
								{
									i++;
									FirstRecordNotFound = "";
									Console.WriteLine("[NOT ACCURATE] i: " + i + "    " + FirstExcelRecord.Name + " " + FirstExcelRecord.NameOfProcedure + " " + FirstExcelRecord.ExecutionDate);
									Console.WriteLine("[NOT ACCURATE] i: " + i + "    " + SecondExcelRecord.Name + " " + SecondExcelRecord.NameOfProcedure + " " + SecondExcelRecord.ExecutionDate);
									list.Add(new CSV_model { Name = SecondExcelRecord.Name, NameOfProcedure = SecondExcelRecord.NameOfProcedure, Priority = FirstExcelRecord.Priority, OrderDate = SecondExcelRecord.OrderDate, ExecutionDate = SecondExcelRecord.ExecutionDate, ResultDate = SecondExcelRecord.ResultDate, Status = SecondExcelRecord.Status, HigOrderDate = SecondExcelRecord.HigOrderDate, Facility = SecondExcelRecord.Facility, OrderingDoctor = SecondExcelRecord.OrderingDoctor, ExecutingDoctor = SecondExcelRecord.ExecutingDoctor, StudyId = SecondExcelRecord.StudyId, PatientId = SecondExcelRecord.PatientId });
									break;
								}
								else if (CompareStrings.Compare(FirstExcelRecord.Name, SecondExcelRecord.Name) && CompareStrings.CompareParentheses(FirstExcelRecord.NameOfProcedure, SecondExcelRecord.NameOfProcedure) && CompareStrings.Compare(FirstExcelRecord.OrderingDoctor, SecondExcelRecord.OrderingDoctor))
								{
									i++;
									FirstRecordNotFound = "";
									Console.WriteLine("[NOT ACCURATE] i: " + i + "    " + FirstExcelRecord.Name + " " + FirstExcelRecord.NameOfProcedure + " " + FirstExcelRecord.ExecutionDate);
									Console.WriteLine("[NOT ACCURATE] i: " + i + "    " + SecondExcelRecord.Name + " " + SecondExcelRecord.NameOfProcedure + " " + SecondExcelRecord.ExecutionDate);
									list.Add(new CSV_model { Name = SecondExcelRecord.Name, NameOfProcedure = SecondExcelRecord.NameOfProcedure, Priority = FirstExcelRecord.Priority, OrderDate = SecondExcelRecord.OrderDate, ExecutionDate = SecondExcelRecord.ExecutionDate, ResultDate = SecondExcelRecord.ResultDate, Status = SecondExcelRecord.Status, HigOrderDate = SecondExcelRecord.HigOrderDate, Facility = SecondExcelRecord.Facility, OrderingDoctor = SecondExcelRecord.OrderingDoctor, ExecutingDoctor = SecondExcelRecord.ExecutingDoctor, StudyId = SecondExcelRecord.StudyId, PatientId = SecondExcelRecord.PatientId });
									break;
								}
								else
								{

									FirstRecordNotFound = "[NOT FOUND] i: " + i + "    " + FirstExcelRecord.Name + " " + FirstExcelRecord.NameOfProcedure + " " + FirstExcelRecord.ExecutionDate;

								}
							}
						}
						if (FirstRecordNotFound != "")
						{
							NotFound.Add(FirstRecordNotFound);
						}
						else { continue; }
					}
                    File.WriteAllLines(path + "\\NotFound.txt", NotFound.Cast<string>());
                    foreach (var item in NotFound)
					{
						Console.WriteLine(item);
					}
				}
				csv3.WriteRecords(list);

			}
        }
		private void AddToList(List<CSV_model> list,string Name, string NameOfProcedure,string Priority,string OrderDate,string ExecutionDate,string ResultDate,string Status,string HigOrderDate,string Facility,string OrderingDoctor,string ExecutingDoctor,string StudyId,string PatientId)
		{
            list.Add(new CSV_model { Name = Name, NameOfProcedure = NameOfProcedure, Priority = Priority, OrderDate = OrderDate, ExecutionDate = ExecutionDate, ResultDate = ResultDate, Status = Status, HigOrderDate = HigOrderDate, Facility = Facility, OrderingDoctor = OrderingDoctor, ExecutingDoctor = ExecutingDoctor, StudyId = StudyId, PatientId = PatientId });
        }
    }
}
