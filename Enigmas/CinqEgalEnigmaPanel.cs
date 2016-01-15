using System.Drawing;
using System.Windows.Forms;


namespace Cpln.Enigmos.Enigmas
{
 
    public class CinqEgalEnigmaPanel : EnigmaPanel
    {
      
        public CinqEgalEnigmaPanel()
        {         
            TableLayoutPanel centerLayout = new TableLayoutPanel();

            // crée les labels différents

            Label[] lblDonnee = new Label[5];
            for (int i=0; i<lblDonnee.Length; i++)
      		{
			lblDonnee[i] = new Label();
      	   
      		}

            //affiche les labels de façon allignée en colonne et en ligne, puis centrée horizontalement et verticalement
            centerLayout.ColumnCount = 3;
            centerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.5f));
            centerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            centerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.5f));
            centerLayout.RowCount = 8;
            centerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 37));
            for (int i = 0; i <=5; i++)
            {
                centerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
            }
            
            centerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 38));
            centerLayout.Dock = DockStyle.Fill;
            Controls.Add(centerLayout);

            //affiche les labels avec toutes leurs propriétés
            CreationLabel(lblDonnee[0], "1 = 5", Color.Blue, centerLayout, 1);
            CreationLabel(lblDonnee[1], "2 = 25", Color.Red, centerLayout, 2);
            CreationLabel(lblDonnee[2], "3 = 325", Color.Purple, centerLayout, 3);
            CreationLabel(lblDonnee[3], "4 = 4325", Color.Green, centerLayout, 4);
            CreationLabel(lblDonnee[4], "5 = ?", Color.Black, centerLayout, 5);

        }

        //Méthode pour définir les différents labels
        private void CreationLabel(Label lbl, string text, Color clr, TableLayoutPanel tlp, int row)
        {

            //permet de paramètrer les labels au niveau de la taille, du texte, de la couleur et de la position
            lbl = new Label();
            lbl.Font = new Font("Arial", 15);
            lbl.Text = text;
            lbl.ForeColor = clr;
            tlp.Controls.Add(lbl, 1, row);
        }
    }
}

 
      		
