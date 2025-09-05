using System.Text.Json;
using SurveyModel;

public class SurveyParser
{
    /// <summary>
    /// Deserializes a JSON string into a Survey object.
    /// </summary>
    /// <param name="jsonContent">The JSON string representing the survey.</param>
    /// <returns>A Survey object, or null if deserialization fails.</returns>
    public static Survey Parse(string jsonContent)
    {
        try
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<Survey>(jsonContent, options);
        }
        catch (JsonException ex)
        {
            // Handle or log the exception as needed
            System.Console.WriteLine($"Error deserializing survey JSON: {ex.Message}");
            return null;
        }
    }
}
