using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class App : MonoBehaviour
{
    [SerializeField] private Slider _progressionBar;
    [SerializeField] private Text _LVL;
    [SerializeField] private Text _XP_To_Next_LVL;
    private Player _player;
    private Attribute _attribute;

    private void Start()
    {
        _player = new Player();
        _attribute = new Attribute(_progressionBar);
        _attribute.maxXP = 10;
    }

    private void Update()
    {
        _progressionBar.maxValue = _attribute.maxXP;

        _LVL.text = _player.FitnessLevel.ToString();
        _XP_To_Next_LVL.text = _attribute.currXP.ToString() + "/" + _attribute.maxXP.ToString();

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _attribute.IncreaseXP(1);
        }
    }
}
