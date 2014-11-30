using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;


namespace BlinkPositive
{
    class Program
    {
        private static int death = 0;
        private static string[] death1;
        private static int messagesent = 0;
        private static string[] WelcomeGame1;
        private static int back = 0;
        private static string[] back1;
        private static int towerdestroyed = 0;
        private static string[] towerdestroyed1;
        private static int kill = 0;
        private static double gamestart;
        private static string[] kill1;
        private static int killspree = 0;
        private static string[] killspree1;
        //private static int pentasteal = 0;
        //private static string[] pentasteal;
        private static string[] EndGame1;
        private static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad +=Game_OnGameLoad;
        }
        private static void Game_OnGameLoad(EventArgs args)
        {

            Game.PrintChat("Blink Positive V1 Loaded Successfully");
            death1 = new[] { "Sorry, that was my fault.", "That was not part of my plan.", "I blame the Riot gods for not buffing my champion!" };
            WelcomeGame1 = new[] { "/all Good Luck, Have Fun!", "/all Let's have a good game of League of Legends!" };
            EndGame1 = new[] { "/all That was a great end to a great game!", "/all GG WP", "/all GG WP", "/all Hope to see you guys later", "/all lots of fun playing this game :)" };
            towerdestroyed1 = new[] { "Great Siege!", "Push dem' Towers baby!", "Pushing harder than my mom!", "Good Objective Control!" };
            kill1 = new[] { "Got him Team :)", "Get em'!", "Staying on top :)" };
            killspree1 = new[] { "Nice Killing Spree!", "Your a true Beast!", "Your just staying on top bb :)" };
            gamestart = Game.Time;

        //    Utility.DelayAction.Add(3, (){Game.Say(WelcomeGame1[messagesent]};
            Utility.DelayAction.Add(3000, () => { Game.Say(WelcomeGame1[messagesent]); });


        }
    }
}
