using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SurveyModel
{
    // Main Survey structure
    public class Survey
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        [JsonPropertyName("pages")]
        public List<Page> Pages { get; set; }

        [JsonPropertyName("themeData")]
        public ThemeData ThemeData { get; set; }

        [JsonPropertyName("settings")]
        public Settings Settings { get; set; }
    }

    public class Page
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("elements")]
        public List<Element> Elements { get; set; }
    }

    public class Element
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("isRequired")]
        public bool IsRequired { get; set; }

        [JsonPropertyName("placeholder")]
        public string Placeholder { get; set; }

        [JsonPropertyName("choices")]
        public List<Choice> Choices { get; set; }

        [JsonPropertyName("rateMax")]
        public int? RateMax { get; set; }
        
        [JsonPropertyName("rateMin")]
        public int? RateMin { get; set; }

        [JsonPropertyName("dateFormat")]
        public string DateFormat { get; set; }
        
        [JsonPropertyName("html")]
        public string Html { get; set; }

        [JsonPropertyName("provider")]
        public string Provider { get; set; }

        [JsonPropertyName("initialMessage")]
        public string InitialMessage { get; set; }

        [JsonPropertyName("qna")]
        public List<QnaItem> Qna { get; set; }

        [JsonPropertyName("geminiSystemPrompt")]
        public string GeminiSystemPrompt { get; set; }

        [JsonPropertyName("ollamaApiUrl")]
        public string OllamaApiUrl { get; set; }

        [JsonPropertyName("ollamaModel")]
        public string OllamaModel { get; set; }
        
        [JsonPropertyName("elements")]
        public List<Element> Elements { get; set; } // For panels

        [JsonPropertyName("visibleIf")]
        public string VisibleIf { get; set; }
    }

    public class Choice
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class QnaItem
    {
        [JsonPropertyName("q")]
        public string Question { get; set; }

        [JsonPropertyName("a")]
        public string Answer { get; set; }
    }

    public class ThemeData
    {
        [JsonPropertyName("fontFamily")]
        public string FontFamily { get; set; }

        [JsonPropertyName("questionFontSize")]
        public string QuestionFontSize { get; set; }

        [JsonPropertyName("questionColor")]
        public string QuestionColor { get; set; }

        [JsonPropertyName("inputBg")]
        public string InputBg { get; set; }

        [JsonPropertyName("inputBorder")]
        public string InputBorder { get; set; }

        [JsonPropertyName("pageBg")]
        public string PageBg { get; set; }

        [JsonPropertyName("buttonBg")]
        public string ButtonBg { get; set; }

        [JsonPropertyName("buttonText")]
        public string ButtonText { get; set; }

        [JsonPropertyName("borderColor")]
        public string BorderColor { get; set; }

        [JsonPropertyName("showAccentBorder")]
        public bool ShowAccentBorder { get; set; }
    }

    public class Settings
    {
        [JsonPropertyName("layout")]
        public string Layout { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }
}
