using Unit3.Game;
namespace Unit3{
     internal class Program
    {
        static void Main(string[] args)
        {
            Jumper dude = new Jumper();
            while(dude.getLifePoints()>0){
                dude.readUserInput();
            }
        }
    }
}
