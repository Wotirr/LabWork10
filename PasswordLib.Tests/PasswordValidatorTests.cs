namespace PasswordLib.Tests

{
    public class PasswordValidatorTests
    {
        [Theory]
        [InlineData("abcdefg1")]
        [InlineData("Abcdefg1")]
        [InlineData("12345678a")]
        [InlineData("PASSWORD123")]
        [InlineData("a1!!!!!!")]
        [InlineData("Пароль123abc")]
        public void IsValidValidPasswordReturnsTrue(string password)
        {
            Assert.True(PasswordValidator.IsValid(password));
        }

        [Theory]
        [InlineData("")]
        [InlineData("a1")]
        [InlineData("abcdef1")]
        [InlineData("abcdefgh")]
        [InlineData("12345678")]
        [InlineData("!!!!!!!!")]
        [InlineData("Пароль123")]
        [InlineData("пароль!!")]
        public void IsValid_InvalidPassword_ReturnsFalse(string password)
        {
            Assert.False(PasswordValidator.IsValid(password));
        }

        [Fact]
        public void IsValid_Null_ReturnsFalse()
        {
            Assert.False(PasswordValidator.IsValid(null));
        }
    }
}