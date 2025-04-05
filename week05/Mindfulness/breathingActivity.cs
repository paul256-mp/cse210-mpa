public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", "Helps you relax through controlled breathing.") { }

    public override void Run()
    {
        base.DisplayStartingMessage();
        
        Console.WriteLine("Follow the breathing guide:\n");
        for (int i = 0; i < Duration / 6; i++) // 3s inhale, 3s exhale per cycle
        {
            Console.Write("Breathe IN... ");
            ShowCountDown(3);
            
            Console.Write("Breathe OUT... ");
            ShowCountDown(3);
        }
        
        base.DisplayEndingMessage();
    }
}