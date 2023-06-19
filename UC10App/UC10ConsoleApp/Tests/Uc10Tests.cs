using UC10ConsoleApp.BL;

namespace UC10ConsoleApp.Tests
{
	public class Uc10Tests
	{
		private readonly Uc10Bl _uc10Bl;

		public Uc10Tests(Uc10Bl uc10Bl)
		{
			_uc10Bl = uc10Bl ?? throw new ArgumentNullException(nameof(uc10Bl));
		}

		public void RunAllTests()
		{
			Console.WriteLine("Tests result:");

			RunTest("LoremiP7$um", 11, true, "Positive test");
			RunTest("LoremiP7$um_long", 10, false, "Maximum string length (too long)");
			RunTest("L7$_short", 11, true, "Maximum string length (too short)");
			RunTest("loremip7$um", 11, false, "At least one uppercase");
			RunTest("LOREMIP7$UM", 11, false, "At least one lowercase");
			RunTest("LoremiPS$um", 11, false, "At least one digit");
			RunTest("LoremiP7sum", 11, false, "At least and one special character");
			RunTest("Lorem P7$um", 11, false, "No whitespaces");


			var specialCharacters = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

			foreach (var specialChar in specialCharacters)
			{
				RunTest($"LoremP7{specialChar}sum", 11, true, $"Special character: {specialChar} ");
			}
		}


		private void RunTest(string inputString, int inputStringLength, bool expectedResult, string testName)
		{
			var result = _uc10Bl.RegExTest(inputString, inputStringLength);

			var testResultStr = result == expectedResult ? "Ok" : "Failed";

			Console.WriteLine($"{testName} : {testResultStr}");
		}

	}
}
