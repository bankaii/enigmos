using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Cpln.Enigmos.Enigmas
{
    public class Enigme42 : EnigmaPanel
    {

      Label[] lblQuaranteDeux = new Label[10];
      public Enigme42()
      {

          //fonction générant de l'aléatoire


          //mise en place du nombre de ligne et de colonne du pannel 
          Random rnd = new Random();
          TableLayoutPanel centerLayout = new TableLayoutPanel();
          centerLayout.ColumnCount = 26;
          for (int i = 0; i < 26; i++)
          {
              centerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.04f));
          }

          centerLayout.RowCount = 21;

          for (int i = 0; i < 21; i++)
          {
              centerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 0.05f));
          }

          centerLayout.Dock = DockStyle.Fill;
          Controls.Add(centerLayout);

          //boucle créant les labels
          for (int i = 0; i < lblQuaranteDeux.Length; i++)
          {
              lblQuaranteDeux[i] = new Label();
              lblQuaranteDeux[i].Text = "42";
              lblQuaranteDeux[i].Font = new Font("Arial", 10);
              int iLocX = rnd.Next(1, 26);
              int iLocY = rnd.Next(1, 21);
              centerLayout.Controls.Add(lblQuaranteDeux[i], iLocX, iLocY);
          }
      }
         
    

//Affiche les labels 
               
            
            }

        }
    

