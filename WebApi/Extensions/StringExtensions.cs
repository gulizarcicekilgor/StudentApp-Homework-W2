using System;
using System.Linq;

namespace WebApi.Extensions
{
    public static class StringExtensions
{
    public static int WordLength(this string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentException("Giriş string'i boş veya null olamaz.", nameof(input));
        }

        // Boşluklara göre böler ve harf sayısını hesaplar
        return input.Split(' ').Select(word => word.Length).Sum();
    }
}

}
