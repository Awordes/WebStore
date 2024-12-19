namespace WebStore.Infrastructure.Exceptions;

public class OptionsBindingException(string optionSectionName)
    : Exception($"Section {optionSectionName} not bind correctly.")
{ }
