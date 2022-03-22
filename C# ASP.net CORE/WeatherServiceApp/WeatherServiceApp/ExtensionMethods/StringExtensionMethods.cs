namespace WeatherServiceApp.ExtensionMethods;

public static class StringExtensionMethods
{
    public static  bool HasValue(this string str )
    {
        return !string.IsNullOrWhiteSpace(str);
    }
}