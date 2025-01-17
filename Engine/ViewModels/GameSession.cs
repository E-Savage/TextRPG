﻿using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * View Models are how classes interact with the GUI
 * how the views and the models interact with each other
 * in our case it is how the player interacts with the 
 * game window
 * 
 */

namespace Engine.ViewModels
{
    /*
     * game sessions makes the session for the game
     * and adds in all the objects we would need to 
     * play the game
     */
    public class GameSession
    {
        // these are properties
        // player that the game session needs 
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        // Methods
        // Constructor for the game session class
        public GameSession()
        {
            // constructs current player and puts it 
            // in the current player property
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Marco the Marvelous";
            CurrentPlayer.CharacterClass = "Mage";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = -1;
            CurrentLocation.ZCoordinate = 0;
            CurrentLocation.Description = "This is your house";
            CurrentLocation.ImageName = "/Engine;component/Images/Locations/Temple1.png";
        }
    }
}
