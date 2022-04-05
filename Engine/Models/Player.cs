using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * new project to keep the models in
 * 
 * Model is used to describe classes 
 * which represent real world objects
 * such as the player
 */
namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        //  backing value for the experience points field so event
        //  can change the value
        // backing variable is a variable the property uses to store its value
        private string _name;
        private string _characterClass;
        private int _hitPoints;
        private int _expereincePoints;
        private int _level;
        private int _gold;


       public  string Name
        { 
            get { return _name; }
            set 
            {
                _name = value;
                OnPropertyChanged("Name");
            } 
        }
       public string CharacterClass 
        { 
            get { return _characterClass; }
            set
            {
                _characterClass = value;
                OnPropertyChanged("CharacterClass");
            } 
        }
       public int HitPoints
        {
            get { return _hitPoints;}
            set
            {
                _hitPoints = value;
                OnPropertyChanged("HitPoints");
            }
        }
       public int ExperiencePoints
        {
            get { return _expereincePoints; }
            set 
            {
                _expereincePoints = value;
                OnPropertyChanged("ExperiencePoints");
            }
        }
       public int Level 
        {
            get { return _level;}
            set
            {
                _level = value;
                OnPropertyChanged("Level");
            }
        }
       public  int Gold 
        {
            get { return _gold;}
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }

        // event to change the properties
       public event PropertyChangedEventHandler? PropertyChanged;

       protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
