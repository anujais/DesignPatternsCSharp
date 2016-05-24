﻿namespace DesignPatterns.Tests.GangOfFour.Structural.Adapter
{
    using DesignPatterns.GangOfFour.Structural.Adapter;

    using NUnit.Framework;

    [TestFixture]
    public class AdapterTest
    {
        private static readonly object[] TestCases =
        {
            new[] { new Book() },
            new[] { new EbookAdapter(new Kindle()) }
        };

        [TestCaseSource(nameof(TestCases))]
        public void TestAdapter(IPaperBook book)
        {
            book.Open();

            book.TurnPage();
        }
    }
}