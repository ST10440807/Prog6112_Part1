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
            PlayGreetingAudio("Cybersecuritychatbot");

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
