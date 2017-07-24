using System;

namespace WarCardGame
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OkButton_Click(object sender, EventArgs e)
        {
            Game game = new Game("Jozef", "Miro");
            Battle battle = new Battle();

            dealLabel.Text = game.DealCards();
            resultLabel.Text = game.PlayGame();
        }
    }
}