using System;

class Program
{
    static void Main(string[] args)
    {
        new GoalManager().Start();

        //Have added extra creativity through:
        //Made it more interesting by removing option for user to define points for a goal
        //instead I have made fixed point per each goal, thus SimpleGoal 20pts, EternalGoal 30pts 
        //and ChecklistGoal 10pts per each achievement and 50 bonus pts once goal completed
        //In doing so, I have been able to implement levels and a user gets bonus as they level up
        //Having a function for showing congratulation emoji after acomplishing a goal or leveling up
        //Cheking if goals are present before saving or recording goal accomplishment
    }
}