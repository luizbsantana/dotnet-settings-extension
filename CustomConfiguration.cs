using System;
using Microsoft.Extensions.Configuration;

namespace Configuration.CustomExtension
{
    /// <summary>
    /// IConfiguration custom extension class
    /// </summary>
    public static class CustomConfiguration
    {
        /// <summary>
        /// Get a custom value from appsettings.json file or EnvironmentVariables system from a given <see cref="string"/> object referencing to the custom value KEY
        /// </summary>
        /// <param name="configuration">The IConfiguration instance</param>
        /// <param name="key">The KEY of the custom value</param>
        /// <returns>The custom value string</returns>
        public static string GetCustomValue(this IConfiguration configuration, string key)
        {
            return configuration[key] ?? configuration[key.ReverseKey()] ?? 
                Environment.GetEnvironmentVariable(key) ?? Environment.GetEnvironmentVariable(key.ReverseKey());
        }

        /// <summary>
        /// Get a custom value from EnvironmentVariables system from a given <see cref="string"/> object referencing to the custom value KEY
        /// </summary>
        /// <param name="key">The KEY of the custom value</param>
        /// <returns>The custom value string</returns>
        public static string GetCustomEnvironmentVariable(string key)
        {
            return Environment.GetEnvironmentVariable(key) ?? Environment.GetEnvironmentVariable(key.ReverseKey());
        }

        private static string ReverseKey(this string key)
        {
            if (key.Contains("_"))
                return key.Replace("_", ":");

            return key.Replace(":", "_");
        }
    }
}
