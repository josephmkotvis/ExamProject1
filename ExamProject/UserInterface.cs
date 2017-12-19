using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    class UserInterface
    {
        SodaMachine sodaMachine;
        public UserInterface(SodaMachine sodaMachine)
        {
            this.sodaMachine = sodaMachine;
        }
        public string GetUserInput()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }
        public void DisplaySodaChoices()
        {
            for (int i =0; i<sodaMachine.inventory.sodas.Count; i++)
            {
                Console.WriteLine(i +") " +sodaMachine.inventory.sodas[i] + Environment.NewLine);
            }
        }
        public void DisplaySodaChoicesQuestion()
        {
            Console.WriteLine("The choices available from the Soda Machine are" +Environment.NewLine);
            DisplaySodaChoices();
            Console.WriteLine("Choose the number according to what you would like.");

        }
        public void DisplaySodaAvailable(string sodaChosen)
        {
            Console.WriteLine("The soda " + sodaChosen + " is in stock.");
        }
        public void DisplayNoSodaAvailable(string sodaChosen)
        {
            Console.WriteLine("The soda " + sodaChosen + " is not in stock.");
        }
        public void DisplaySodaPrice(double price)
        {
            Console.WriteLine("The price for the soda you have selected is " + price + "$.");
        }
        public void DisplayOpinionQuestion()
        {
            Console.WriteLine("Would you still like to purhcase this soda?" + Environment.NewLine + "1) Yes" + Environment.NewLine + "2) No");
        }
        public void DisplaySodaBought(string sodaChoice)
        {
            Console.WriteLine("You have succesfully bought a can of " + sodaMachine.inventory.sodas[Convert.ToInt32(sodaChoice)]);
        }
    }
}
