using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class IdleSkatingMain : MonoBehaviour
{
    // Initialization
    private bool _gameInitialized; // Set to false to start, true once a new game is started. Ensures we don't reset game. 

    
    // Resources
    private double _money; // Cash on hand
    private int _time; // Time able to devote to growth
    
    public Text moneyDisplay;
    
    // Calculations
    private double _dt; // Delta time

// Visualization Bars

    private Slider _speedSlider;
    private Text _sliderTime;
    
    // Click Data
    private double _coinsPerClick;
    
    // Navigation
    private string _activeState;

    // Generate Lists
    List<WorkOutButton> _workOutGenerators = new List<WorkOutButton>();
    private List<EarnButton> _earnGenerators = new List<EarnButton>();
    
    
    public void Start()
    {
        // Initial values
        if (!_gameInitialized)
            NewGame();

    }

    private void NewGame()
    {
        _money = 0;
        _time = 1;
        _gameInitialized = true;
    }

    public void Update()
    {
        _dt = Time.deltaTime;
        foreach (var gen in _workOutGenerators)
        {
            gen.CalcWorkout(_dt);
        }
        
        foreach (var gen in _earnGenerators)
        {
            gen.CalcEarnings(_dt);
        }
        
        moneyDisplay.text = "Cash: " + _money;
    }

    
    // Money Functions
    
    // Will Return true if it can be purchased and will deduct the amount
    public bool MakePurchase(double cost)
    {
        if (_money > cost)
        {
            _money -= cost;
            return true;
        }

        return false;
    }

    public double GetMoney()
    {
        return _money;
    }

    public void AddMoney(double money)
    {
        _money += money;
    }

    // Generator Tracker Operations
    public void RegisterGenerator(EarnButton gen)
    {
        _earnGenerators.Add(gen);
    }
    
    public void RegisterGenerator(WorkOutButton gen)
    {
        _workOutGenerators.Add(gen);
    }
    
}


