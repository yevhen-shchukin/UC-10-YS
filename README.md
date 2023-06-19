# Application description
This application is made within the scope of Use Case 10 of the AI-backed testing (no AI help).
It consists of two parts:
- Regular Exception business logic function
- Test function
It is written with .NET 6 as a console application.

# Regex implementation details
The Regular Expression business logic tests the input strings with a special RegEx to check if the input meets the requirements.
The RegEx itself consists of the following parts:

- (?=.*[A-Z]) - Check for at least one uppercase character
- (?=.*[a-z]) - Check for at least one lowercase character
- (?=.*\\d) - Check for at least one digit
- (?=.*[!\"#$%&'()*+,\\-./:;<=>?@[\\\\\\]^_`{{|}}~])(?!.*[\\s]) - Check for at least one special character 
- (.{{1,{0}}}) - Check for maximum length

All thees parts are combined into a single RegEx.

# How to run the developed application locally
To run the app locally, you need to open the solution with VS and run the app with the F5 key.
No additional settings are required.