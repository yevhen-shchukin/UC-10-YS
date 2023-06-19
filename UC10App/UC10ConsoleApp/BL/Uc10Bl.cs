using System.Text.RegularExpressions;

namespace UC10ConsoleApp.BL
{
	public class Uc10Bl
	{
		public bool RegExTest(string inputString, int inputStringLength)
		{
			var patternFormat = "^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[!\"#$%&'()*+,\\-./:;<=>?@[\\\\\\]^_`{{|}}~])(?!.*[\\s])(.{{1,{0}}})$";

			var pattern = string.Format(patternFormat, inputStringLength.ToString());

			var rg = new Regex(pattern);

			return rg.IsMatch(inputString);
		}

	}
}
