using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarnButton : MonoBehaviour
{
    public IdleSkatingMain main;
    public double baseMoneyPerSec;
    private int _count;
    public double baseCost;
    public double costMult;
    private double _currMoneyPerSec;
    
    
    // Start is called before the first frame update
    void Start()
    {
        main.RegisterGenerator(this);
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    public void CalcEarnings(double dt)
    { 
        main.AddMoney(_currMoneyPerSec * dt);
    }

    public void Buy()
    {
        if(main.MakePurchase(baseCost * (Math.Pow(costMult,_count))))
        {
            _count++;
            _currMoneyPerSec = baseMoneyPerSec * _count;
        }
    }
    
    
}
