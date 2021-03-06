﻿using MarieZoo.Interfaces;
using System;

using System.Collections.Generic;

namespace MarieZoo.Fish
{

    //CONCRETE CLASS
    public class Stingray : Fish, IFeed, ISound, IDesign
    {
        public override string Name { get; set; }
       

        public override string Predator()
        {
            return "I am prone to attack by larger rays and a wide variety of sharks";
        }

        public override string FunFact()
        {
           return "Ancient Greek dentists used the venom from the sting ray's spine as an anesthetic";
        }

        public decimal LengthInInches => 15;

        public string Color => "Royal blue with ivory white spots to reflect the sea floors shading to protect me from my predators.";

        public string LegsOrFins => "I have two powerful fins that let me glide through the open ocean";

        

        public string Movement => " We undulate like a wave or flap our fins/sides like wings";

     
        public override string GetDiet()
        {
            return "I love eating squid and mollusks";
        }

        public override int GetNumberOfTeeth()
        {
            return 0;
        }

     

        protected override void AdditionalDisplay()
        {
            Console.WriteLine();
        }

       




        string ISound.GetMakeSound()
        {
            return "blub blub";
        }


        public string FeedMe { get; set; } = "Purchase squid at the counter for $10";
    }
}
