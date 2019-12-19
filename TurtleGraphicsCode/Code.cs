using System;

namespace TurtleGraphicsCode
{

    public class Code
    {

        /// <summary>
        /// This is the place to put your turtle code
        /// </summary>
        public Turtle ToExecute()
        {
            Turtle t = new Turtle(true);
            t.BackgroundColor = "Black";
            t.Rotate(-90);
            t.TurtleSpeed = 15;
            for (int i = 0; i < 6; i++)
            {
                t.StoreTurtlePosition();

                for (int j = 0; j < 20; j++)
                {
                    DrawSection(t, 100 -5*j);
                }

                t.RestoreTurtlePosition();
                t.Rotate(60);
                t.CaptureScreenshot();
            }
            return t;
        }

        void DrawSection(Turtle t, int p)
        {
            for (int i = 0; i < 10; i++)
            {

                t.Forward(2);

                t.SetColor(90 + i*15, 170, 200);

            }
            t.StoreTurtlePosition();
            t.Rotate(-45);
            for (int i = 0; i < p; i++)
            {
                t.Forward(1);
                t.SetColor(i + 100,0,0);
            }
            t.SetColor(90, 170, 200);
            t.RestoreTurtlePosition();
            t.Rotate(45);
            t.Forward(p);
            t.RestoreTurtlePosition(true);
        }
    }
}













//Vytvořím si složku na disku Z: na mé projekty ve Visual Studiu
//Otevřu cmd/powershell v složce z řádku 11
//Zadám 'git clone https://github.com/Michal-MK/TurtleGraphics.git'
//Ovetřu stažený solution ve visual studiu(.sln soubor)
//Najdu projekt 'TurteGraphicsCode'
//Najdu soubor Code.cs a otevřu ho
//Jsem zde!