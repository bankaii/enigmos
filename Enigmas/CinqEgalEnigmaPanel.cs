using System.Drawing;
using System.Windows.Forms;


namespace Cpln.Enigmos.Enigmas
{
    /// <summary>
    /// Exemple d'énigme très simple. Seul un texte est affiché.
    /// </summary>
    public class CinqEgalEnigmaPanel : EnigmaPanel
    {
        private System.Windows.Forms.TableLayoutPanel centerLayout;
        private System.Windows.Forms.Label lblDonnee1;
        private System.Windows.Forms.Label lblDonnee2;
        private System.Windows.Forms.Label lblDonnee3;
        private System.Windows.Forms.Label lblDonnee4;
        private System.Windows.Forms.Label lblDonnee5;

        /// <summary>
        /// Constructeur par défaut, génère un texte et l'affiche dans le Panel.
        /// </summary>
        public CinqEgalEnigmaPanel()
        {

            TableLayoutPanel centerLayout = new TableLayoutPanel();

            //Crée des labels

            Label lblDonnee1 = new Label();
            Label lblDonnee2 = new Label();
            Label lblDonnee3 = new Label();
            Label lblDonnee4 = new Label();
            Label lblDonnee5 = new Label();


            //ajoute du texte dans les labels

            lblDonnee1.Text = "1 = 5";
            lblDonnee2.Text = "2 = 25";
            lblDonnee3.Text = "3 = 235";
            lblDonnee4.Text = "4 = 4325";
            lblDonnee5.Text = "5 = ?";

            lblDonnee1.ForeColor = Color.Blue;
            lblDonnee2.ForeColor = Color.Red;
            lblDonnee3.ForeColor = Color.Purple;
            lblDonnee4.ForeColor = Color.Green;
            lblDonnee5.ForeColor = Color.Black;

            //permet de paramètrer les labels au niveau de la taille, du texte, de la couleur et de la position
            

            lblDonnee1.Font = new Font("Arial", 15);
            lblDonnee2.Font = new Font("Arial", 15);
            lblDonnee3.Font = new Font("Arial", 15);
            lblDonnee4.Font = new Font("Arial", 15);
            lblDonnee5.Font = new Font("Arial", 15);

            //affiche les labels de façon allignée en colonne et centrée horizontalement
            centerLayout.ColumnCount = 3;
            centerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.5f));
            centerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            centerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.5f));
            centerLayout.RowCount = 7;
            centerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 37));
            centerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
            centerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
            centerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
            centerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
            centerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
            centerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 38));
            centerLayout.Dock = DockStyle.Fill;
            Controls.Add(centerLayout);

            centerLayout.Controls.Add(lblDonnee1, 1, 1);
            centerLayout.Controls.Add(lblDonnee2, 1, 2);
            centerLayout.Controls.Add(lblDonnee3, 1, 3);
            centerLayout.Controls.Add(lblDonnee4, 1, 4);
            centerLayout.Controls.Add(lblDonnee5, 1, 5);
    

            ;

        }
    }
}
