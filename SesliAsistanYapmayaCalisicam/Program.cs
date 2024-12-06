using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace SesliAsistanYapmayaCalisicam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Speak("Merhaba! Ben senin sesli asistanınım.");
           synthesizer.Speak("Batuhan Çok yaşa");
           synthesizer.Speak("Yapımcım : Batuhan .");
            synthesizer.Speak("Şevval Seni Seviyorum");
            

            Console.ReadLine();

        }
    }
}
