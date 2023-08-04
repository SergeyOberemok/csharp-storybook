﻿using FluentAssertions;
using System.Text.RegularExpressions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Strings
{
    public class ChangeTests : TestBase
    {
        public ChangeTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestReplace()
        {
            string sentence = _faker.Lorem.Sentence();

            string result = Regex.Replace(sentence, @"[\s\.]+", "");

            result.Contains(' ').Should().BeFalse();
        }

        [Fact]
        public void TestJoin()
        {
            string word1 = _faker.Lorem.Word();
            string word2 = _faker.Lorem.Word();
            string separator = ", ";

            string phrase = string.Join(separator, word1, word2);

            phrase.Should().Be($"{word1}{separator}{word2}");
        }

        [Fact]
        public void TestToStringWithFormat()
        {
            string format = "x4";
            int aNumber = 0x22;
            char aChar = 'a';

            aNumber.ToString(format).Should().Be("0022");
            ((int)aChar).ToString(format).Should().Be("0061");
        }

        [Fact]
        public void TestAtobBase64ToStringConvert()
        {
            string base64Encoded = "anVzdHluYQ==";

            string base64Decoded = base64Encoded.Atob();

            base64Decoded.Should().Be("justyna");
        }
    }
}
