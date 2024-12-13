using System.Text.RegularExpressions;

namespace gym_app
{
    public static class Validator
    {
        // Validate if a string is not empty or null
        public static bool IsNotEmpty(string input)
        {
            return !string.IsNullOrEmpty(input);
        }

        // Validate email format
        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        // Validate password length (e.g., at least 8 characters)
        public static bool IsValidPassword(string password)
        {
            return password.Length >= 8;
        }

        // Additional validation if needed (e.g., contains special characters, etc.)
        public static bool ContainsSpecialCharacter(string input)
        {
            string specialCharPattern = @"[!@#$%^&*(),.?""':{}|<>]";
            return Regex.IsMatch(input, specialCharPattern);
        }
        // Validate if a string is not empty or null
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Check if the phone number is numeric and has exactly 8 digits
            return phoneNumber.All(char.IsDigit) && phoneNumber.Length == 8;
        }

        // Validate CIN (8-digit number)
        public static bool IsValidCIN(string cin)
        {
            // Check if CIN is numeric and has exactly 8 digits
            return cin.All(char.IsDigit) && cin.Length == 8;
        }

        // Validate if a string is a valid number
        public static bool IsValidNumber(string number)
        {
            return double.TryParse(number, out _);
        }

    }
}
