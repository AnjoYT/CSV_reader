using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CSV_reader
{
	internal class CompareStrings
	{
		static CompareStrings()
        {

        }
		private static string WhiteSignsRemoval(string ToBeNormalized)
		{
			ToBeNormalized = Regex.Replace(ToBeNormalized,@"\s","");
			return ToBeNormalized;
		}
		public static bool Compare(string FirstRecord, string SecondRecord)
		{

			if (WhiteSignsRemoval(FirstRecord) == WhiteSignsRemoval(SecondRecord)) 
			{
				return true;
			}
			else { return false; }
		}
		public static bool CompareParentheses(string FirstRecord, string SecondRecord)
		{
			if (Regex.IsMatch(FirstRecord, @"\([^)]*\)")|| Regex.IsMatch(SecondRecord, @"\([^)]*\)"))
			{
				return Compare(RemoveParentheses(FirstRecord), RemoveParentheses(SecondRecord));
			}else return false;
			
		}
		private static string RemoveParentheses(string ToBeRemoved)
		{
			ToBeRemoved = Regex.Replace(ToBeRemoved, @"\s*\([^)]*\)", "");
			return ToBeRemoved;
		}

	}
}
