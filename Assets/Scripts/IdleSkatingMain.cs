using System;
using System.Threading;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IdleSkatingMain : MonoBehaviour
{
    

    
    // Resources
    public int influence;
    public int influencePerDay;

    public Text influenceText;
    public Text influencePerDayText;
    

    // Pacing
    private double dayProgress;
    private double days;
    private Text DaysText;
    
    // Visualization Bars

    private Slider speedSlider;
    private Text sliderTime;
    
    // Click Data
    private double coinsPerClick;
    
    // Navigation
    private string[] navStates; // Reference for various nav states
    private string activeState;
    
    // private int topLevelNavActive; // The active main nav state
    // private int subMenuGroupActive; // The active sub-nav state (within the main nav, where applicable)
    // private int subSubMenuGroupActive; // The active sub-sub-nav state (where applicable)
    
    public CanvasGroup topLevelNavWorkout;
    public CanvasGroup subNavWorkoutExercises;
    public CanvasGroup subNavWorkoutData;
    public CanvasGroup subNavWorkoutUpgrades;
    
    public CanvasGroup topLevelNavTrain;
    public CanvasGroup subNavTrainSkills;
    public CanvasGroup subSubNavTrainExercisesJumps;
    public CanvasGroup subSubNavTrainExercisesSpins;
    public CanvasGroup subSubNavTrainExercisesFlyingSpins;
    public CanvasGroup subSubNavTrainExercisesOther;
    public CanvasGroup subNavTrainUpgrades;
    
    public CanvasGroup topLevelNavEarn;
    public CanvasGroup subNavEarnIncome;
    public CanvasGroup subNavEarnUpgrades;

    public CanvasGroup topLevelNavCompete;
    public CanvasGroup subNavCompeteProgram;
    public CanvasGroup subNavCompeteCompetition;



    
    public void Start()
    {
        // Initial values


    }

    public void Update()
    {
        
    }

    
    // Buttons
    public void ClickCoins()
    {

    }

    // public void SwitchTab(string newState)
    // {
    //     activeState = newState;
    //     DisableCanvasGroups();
    //     switch (activeState)
    //     {
    //         case "WorkOutExercises":
    //             topLevelNavWorkout.alpha = 1;
    //             topLevelNavWorkout.interactable = true;
    //             topLevelNavWorkout.blocksRaycasts = true;
    //             subNavWorkoutData.alpha = 1;
    //             subNavWorkoutData.interactable = true;
    //             subNavWorkoutData.blocksRaycasts = true;
    //             subNavWorkoutExercises.alpha = 1;
    //             subNavWorkoutExercises.interactable = true;
    //             subNavWorkoutExercises.blocksRaycasts = true;
    //             subNavWorkoutUpgrades.alpha = 0;
    //             subNavWorkoutUpgrades.interactable = false;
    //             subNavWorkoutUpgrades.blocksRaycasts = false;
    //             break;
    //         case "WorkOutUpgrades": 
    //             topLevelNavWorkout.alpha = 1;
    //             topLevelNavWorkout.interactable = true;
    //             topLevelNavWorkout.blocksRaycasts = true;
    //             subNavWorkoutData.alpha = 1;
    //             subNavWorkoutData.interactable = true;
    //             subNavWorkoutData.blocksRaycasts = true;
    //             subNavWorkoutUpgrades.alpha = 1;
    //             subNavWorkoutUpgrades.interactable = true;
    //             subNavWorkoutUpgrades.blocksRaycasts = true;
    //             subNavWorkoutExercises.alpha = 0;
    //             subNavWorkoutExercises.interactable = false;
    //             subNavWorkoutExercises.blocksRaycasts = false;
    //             break;
    //         case "TrainUpgrades":
    //             topLevelNavTrain.alpha = 1;
    //             topLevelNavTrain.interactable = true;
    //             topLevelNavTrain.blocksRaycasts = true;
    //             break;
    //
    //         
    //     }
    // }

    // private void DisableCanvasGroups()
    // {
    //     topLevelNavWorkout.alpha = 0;
    //     topLevelNavWorkout.interactable = false;
    //     topLevelNavWorkout.blocksRaycasts = false;
    //     topLevelNavTrain.alpha = 0;
    //     topLevelNavTrain.interactable = false;
    //     topLevelNavTrain.blocksRaycasts = false;
    // }
    
}


