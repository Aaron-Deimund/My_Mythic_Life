using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayerTests
    {
        private Player _player;

        [SetUp]
        public void BeforeEveryTest()
        {
            _player = new Player();
        }

        [Test]
        public void _Increase_FitnessLevel_With_0_Value_To_1_Value()
        {
            _player.FitnessLevel = 0;

            _player.IncreaseFitnessLevel();

            Assert.AreEqual(1, _player.FitnessLevel);
        }

        [Test]
        public void _Increase_FitnessLevel_With_1_Value_To_2_Value()
        {
            _player.FitnessLevel = 1;

            _player.IncreaseFitnessLevel();

            Assert.AreEqual(2, _player.FitnessLevel);
        }
    }
}
