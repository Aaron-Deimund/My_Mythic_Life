using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;

namespace Tests
{
    public class AttributeTests
    {
        public class IncreaseXP
        {
            private Slider _progressionBar;
            private Attribute _attribute;
            private Player _player;

            [SetUp]
            public void BeforeEveryTest()
            {
                _progressionBar = new GameObject().AddComponent<Slider>();
                _attribute = new Attribute(_progressionBar);
                _player = new Player();
            }

            [Test]
            public void _0_Sets_ProgressionBar_With_0_Value_To_0_Value()
            {
                _progressionBar.value = 0;

                _attribute.IncreaseXP(0);

                Assert.AreEqual(0, _progressionBar.value);
            }

            [Test]
            public void _1_Sets_ProgressionBar_With_0_Percent_To_100_PercentFill()
            {
                _progressionBar.value = 0;

                _attribute.IncreaseXP(1);

                Assert.AreEqual(1, _progressionBar.value);
            }

            [Test]
            public void _50_Percent_Sets_ProgressionBar_With_50_Percent_To_100_PercentFill()
            {
                _progressionBar.value = .5f;

                _attribute.IncreaseXP(.5f);

                Assert.AreEqual(1, _progressionBar.value);
            }

            [Test]
            public void _0_Value_Sets_ProgressionBar_With_0_Percent_To_50_Percent_Fill_With_XPCap_Of_10()
            {
                _progressionBar.maxValue = 10f;
                _progressionBar.value = 0f;

                _attribute.IncreaseXP(5f);

                Assert.AreEqual(5, _progressionBar.value);
            }

            [Test]
            public void _5_Value_Sets_ProgressionBar_With_50_Percent_To_100_Percent_Fill_With_XPCap_Of_10()
            {
                _progressionBar.maxValue = 10f;
                _progressionBar.value = 5f;

                _attribute.IncreaseXP(5f);

                Assert.AreEqual(10f, _progressionBar.value);
            }

            [Test]
            public void _currXp_Is_being_updated()
            {
                _progressionBar.maxValue = 10f;
                _progressionBar.value = 5f;
                _attribute.currXP = (int)_progressionBar.value;
                _attribute.IncreaseXP(5f);

                Assert.AreEqual(10f, _progressionBar.value);
            }

            [Test]
            public void _Increaseing_currXp_To_MaxXP_LevelsUp()
            {
                _player.FitnessLevel = 0;
                _progressionBar.maxValue = 10f;
                _progressionBar.value = 5f;
                _attribute.currXP = 5;//(int)_progressionBar.value;
                _attribute.maxXP = (int)_progressionBar.maxValue;
                _attribute.IncreaseXP(5f);
                //2/14/2021 JKS Left off here. This is properly working but Needs a DECREASING XP FUNCTION!@!!!
                Assert.AreEqual(_attribute.currXP, _attribute.maxXP);
            }

            [Test]
            public void _Increaseing_currXp_Over_MaxXP_LevelsUp_And_Bleeds_Over()
            {

            }
        }
    }
}
