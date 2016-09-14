using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Coupling_MVC_CardConcepts;

namespace Coupling_MVC_Deal
{
    // defines the type of method that observes model updates:
    public delegate void Observer();
    // defines the type of method that handles an input event (button press):
    public delegate void InputHandler(object sender, EventArgs e);

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // WRITE ME: CONSTRUCT MODEL OBJECTS
            //           CONSTRUCT CONTROLLER
            //           FINISH CODE IN INPUT VIEW
            //           CONSTRUCT VIEWS
            //           REGISTER VIEWS WITH CONTROLLER
            //           START THE SYSTEM
            Deck d = new Deck();
            Hand h = new Hand();
            GameController gc = new GameController(d,h);
            ScoreForm sf = new ScoreForm(h);
            MainForm mf = new MainForm(gc.handle, h);
            sf.Show();
            gc.register(mf.showCards);
            gc.register(sf.showScore);
            Application.Run(mf);
           // MessageBox.Show("Click to exit.", "Exit");
        }
    }
}
