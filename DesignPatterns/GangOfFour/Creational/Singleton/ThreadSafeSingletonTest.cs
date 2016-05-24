﻿namespace DesignPatterns.Tests.GangOfFour.Creational.Singleton
{
    using DesignPatterns.GangOfFour.Creational.Singleton;

    using NUnit.Framework;

    [TestFixture]
    public class ThreadSafeSingletonTest
    {
        [Test]
        public void TestOnlyOneInstanceIsCreated()
        {
            var instance1 = ThreadSafeSingleton.Instance;
            var instance2 = ThreadSafeSingleton.Instance;

            Assert.That(instance1, Is.EqualTo(instance2));
        }
    }
}