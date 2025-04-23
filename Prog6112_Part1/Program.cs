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
        //Greeting audio Method
        static void PlayGreetingAudio(string filePath)
        {
            try
            {
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "Greeting Audio", "Cybersecuritychatbot .wav");
                //Error handling for audio greeting
                if (File.Exists(fullPath))
                {
                    SoundPlayer player = new SoundPlayer(fullPath);
                    player.PlaySync();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error: File not found at {fullPath}");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error playing audio: {ex.Message}");
            }
        }
        //Response system
        static void HandleUserQuery(string userInput, string userName)
        {  //Q&A  setup
            Dictionary<string, string> responses = new Dictionary<string, string>
            { //Questions and responses based on user input
                { "how are you", "I cant complain thanks for asking." },
                { "what's your purpose", "I'm here to keep you safe online.What Safety tips would you like to know phishing,passwords or links ?" },
                { "what can I ask you about","You can ask me about online safety tips.What Safety tips would you like to know phishing,passwords or links ?"},
            };

            if (responses.ContainsKey(userInput))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(responses[userInput]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("I'm sorry, I don't understand. What Safety tips would you like to know?(phishing/passwords/links?");
                string response = Console.ReadLine()?.ToLower().Trim();

                if (response == "phishing")
                {
                    PhishingTips();//Call safety tips method
                }
                if (response == "passwords")
                {
                    PasswordTips();
                }
                if (response == "links")
                {
                    LinkTips();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Chatbot: Let me know if you have any other questions or type exit to close application.");
                }
            }
        }
        //Tips methods
        static void PhishingTips()
        {  //Define phishing 
            Console.WriteLine(".What's Phishing?,Its a type of cyberattack where scammers trick you into giving away personal information" +
                              " like passwords or credit card numbers by pretending to be a trusted source.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Chatbot: Here are some essential tips to avoid phishing:");
            Console.WriteLine("1.Never give passwords or bank details via email or any unverified links.");
            Console.WriteLine("2.Don’t click on suspicious or unverified links,Hover over links before clicking to check where they lead.");
            Console.WriteLine("3.Verify the sender by checking the email address carefully.");
        }
        static void PasswordTips()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Chatbot: Here are some helpful Password practises:");
            Console.WriteLine("1. Use different passwords for each account.");
            Console.WriteLine("2. Enable two-factor authentication (2FA).");
            Console.WriteLine("3. Don’t share your passwords.");
            Console.WriteLine("4. Avoid common passwords ,Don’t use “123456”, “password”, or your name.");
        }
        static void LinkTips()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Chatbot: Here are some  essential safe browsing practises and link safety tips:");
            Console.WriteLine("1. Keep your browser updated,updates include patches that fix security holes.");
            Console.WriteLine("2. Don’t download anything from untrusted or illegal sites.");
            Console.WriteLine("3. Hover over links before clicking.");
            Console.WriteLine("4. Don’t click links in unsolicited emails or texts.");
        }
    }
}
