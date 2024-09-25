using System.Text.RegularExpressions;

string rawUrl = "https://example.com//path//to///resource";
string cleanedUrl = TrimUrlExtraSlashes(rawUrl);

static string TrimUrlExtraSlashes(string url)
{
    if (string.IsNullOrEmpty(url))
        return url;

    var parts = url.Split(new[] {"://"},2,StringSplitOptions.None);

    if (parts.Length != 2)
        return url;

    var fixedPart = Regex.Replace(parts[1],"/{2,}", "/");
    return $"{parts[0]}://{fixedPart}";

}
