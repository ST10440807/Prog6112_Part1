using System;
using System.Collections.Generic;//Enables dictionary usage*
using System.IO;//Handles file operations
using System.Linq;
using System.Media;//Enables audio playback
using System.Text;
using System.Threading.Tasks;
/* Chatbot for cyber-security awareness
    * Phishing scams,malware and social engineering,discuss safe password practises and recognizing suspicious links
    */

namespace CybersecurityAwarenessAssistant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Play audio greeting
            PlayGreetingAudio("Cybersecuritychatbot .wav");

            //HeaderAscii Art 
            Console.Title = "Cyber-Security Assistant Chatbot";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"

            
 ██████╗██╗   ██╗██████╗ ███████╗██████╗       ███████╗███████╗ ██████╗██╗   ██╗██████╗ ██╗████████╗██╗   ██╗    ██████╗  ██████╗ ████████╗    
██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗      ██╔════╝██╔════╝██╔════╝██║   ██║██╔══██╗██║╚══██╔══╝╚██╗ ██╔╝    ██╔══██╗██╔═══██╗╚══██╔══╝    
██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝█████╗███████╗█████╗  ██║     ██║   ██║██████╔╝██║   ██║    ╚████╔╝     ██████╔╝██║   ██║   ██║       
██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗╚════╝╚════██║██╔══╝  ██║     ██║   ██║██╔══██╗██║   ██║     ╚██╔╝      ██╔══██╗██║   ██║   ██║       
╚██████╗   ██║   ██████╔╝███████╗██║  ██║      ███████║███████╗╚██████╗╚██████╔╝██║  ██║██║   ██║      ██║       ██████╔╝╚██████╔╝   ██║       
 ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝      ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚═╝   ╚═╝      ╚═╝       ╚═════╝  ╚═════╝    ╚═╝       
                                                                                                                                               
            
");

            //UI Setup and Text based greeting
            //welcome ascii art 
            Console.WriteLine(@"


         __    __     _                          
        / / /\ \ \___| | ___ ___  _ __ ___   ___ 
        \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \
         \  /\  /  __/ | (_| (_) | | | | | |  __/
          \/  \/ \___|_|\___\___/|_| |_| |_|\___|
                                         
           
            
        ");
            Console.Title = "Cyber-Security Assistant Chatbot";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to the CyberSecurity Assistance Chatbot!");
            Console.WriteLine("I am here to help you stay safe online what is your name.");//Prompt user name
            Console.ForegroundColor = ConsoleColor.Cyan;
            string userName = Console.ReadLine();//Read user input and save username
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Hey {userName}! How can I help you today?");
            Console.WriteLine("You can ask about security concerns such as password safety,phishing and safe browsing,or type 'exit' to quit.\n");

            while (true)//Loop to keep program running until user says exit 
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{userName}:  ");
                string userInput = Console.ReadLine()?.ToLower().Trim();//Format user input 
                //Error handling 
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid input.");
                    continue;
                }
                //Exit application upon user request
                if (userInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Goodbye! Have a nice day and stay safe online!");
                    break;
                }
                HandleUserQuery(userInput, userName);
            }
        }
