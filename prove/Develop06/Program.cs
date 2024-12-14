using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = GoalManager.Instance; 
        goalManager.Start();
    }
}

// Enhancements beyond core requirements: 
// Added a NegativeGoal class that deducts points when recorded. 
// Implemented a leveling-up mechanism based on the user's score. 
// Provided a menu option to create and record negative goals. 
// Added level display and level-up notification for additional gamification.