namespace LuhnValidatorAPI.Services
{
    public interface ILuhnValidator
    {
        bool IsValid(string value);
    }
}
