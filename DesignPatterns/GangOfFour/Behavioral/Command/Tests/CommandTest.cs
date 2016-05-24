﻿namespace DesignPatterns.Tests.GangOfFour.Behavioral.Command
{
    using DesignPatterns.GangOfFour.Behavioral.Command;

    using NUnit.Framework;

    [TestFixture]
    public class CommandTest
    {
        [Test]
        public void TestCommand()
        {
            var lamp = new Light();
            var closeCommand = new CloseSwitchCommand(lamp);
            var openCommand = new OpenSwitchCommand(lamp);
            var @switch = new Switch(closeCommand, openCommand);

            @switch.Open();

            @switch.Close();
        }
    }
}