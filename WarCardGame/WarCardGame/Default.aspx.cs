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
            Deck deck = new Deck();

            Player player = new Player();

            deck.DealAllCards();

            foreach (var pl in deck.PlayerOne.Card)
            {
                resultLabel.Text += string.Format("<br/>Player one {0} {1}", pl.Kind, pl.Value);
            }

            foreach (var pl2 in deck.PlayerTwo.Card)
            {
                resultLabel.Text += string.Format("<br/>Player two {0} {1}", pl2.Kind, pl2.Value);
            }

        }
    }
}