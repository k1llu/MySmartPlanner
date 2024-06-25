using Xunit;
using SmartPlanner.UserControls;

namespace SmartPlanner.Tests
{
    public class RegistrationTests
    {
        private readonly Registration_UC reg_UC;
        public RegistrationTests()
        {
            reg_UC = new Registration_UC();
        }

        [Fact]
        public void ShortUsernameTest()
        {
            var result = reg_UC.ValidateInputs("use", "email@example.com", "UserTest!12345", "UserTest!12345");
            Assert.Contains("Username must be in range of 4-16 letters.", result);
        }
        [Fact]
        public void LongUsernameTest()
        {
            var result = reg_UC.ValidateInputs("usernameisverylongforit", "email@example.com", "UserTest!12345", "UserTest!12345");
            Assert.Contains("Username must be in range of 4-16 letters.", result);
        }
        [Fact]
        public void UsernameCorrect()
        {
            var result = reg_UC.ValidateInputs("username", "email@example.com", "UserTest!12345", "UserTest!12345");
            Assert.DoesNotContain("Username must be in range of 4-16 letters.", result);
        }
        [Fact]
        public void WrongEmailTest()
        {
            var result = reg_UC.ValidateInputs("username", "emailexample.com", "UserTest!12345", "UserTest!12345");
            Assert.Contains("Email must be like john.doe@example.com.", result);
        }
        [Fact]
        public void EmailCorrect()
        {
            var result = reg_UC.ValidateInputs("username", "email@example.com", "UserTest!12345", "UserTest!12345");
            Assert.DoesNotContain("Email must be like john.doe@example.com.", result);
        }

        [Fact]
        public void TestPasswordSmallPassword()
        {
            var result = reg_UC.ValidateInputs("username", "email@example.com", "Sm1!", "Sm1!");
            Assert.Contains("Password must conatin more than 8 letters, 1 special symbol, number and upper case.", result);
        }

        [Fact]
        public void TestPasswordForSpecialSymbol()
        {
            var result = reg_UC.ValidateInputs("username", "email@example.com", "Password123", "Password123");
            Assert.Contains("Password must conatin more than 8 letters, 1 special symbol, number and upper case.", result);
        }

        [Fact]
        public void TestPasswordForNumber()
        {
            var result = reg_UC.ValidateInputs("username", "email@example.com", "Password!", "Password!");
            Assert.Contains("Password must conatin more than 8 letters, 1 special symbol, number and upper case.", result);
        }

        [Fact]
        public void TestPasswordCorrectPassword()
        {
            var result = reg_UC.ValidateInputs("username", "email@example.com", "Password123!", "Password123!");
            Assert.DoesNotContain("Password must conatin more than 8 letters, 1 special symbol, number and upper case.", result);
        }

        [Fact]
        public void TestPasswordNoUpperCase()
        {
            var result = reg_UC.ValidateInputs("username", "email@example.com", "password123!", "password123!");
            Assert.Contains("Password must conatin more than 8 letters, 1 special symbol, number and upper case.", result);
        }

        [Fact]
        public void TestPasswordMismatch()
        {
            var result = reg_UC.ValidateInputs("username", "email@example.com", "Password123!", "DifferentPassword123!");
            Assert.Contains("Confirm password must metch password.", result);
        }
    }
}
