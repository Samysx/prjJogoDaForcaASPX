using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjJogoDaforca
{
    public partial class jogoDaForca : System.Web.UI.Page
    {
        static String x = "Nic"; // variavel da palavra
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "")
                {
                    txtNome.Text = "campo vazio insira 3 letras";
                }
                else
                {
                    char a = x.ElementAt(0); //vai criar uma variavel "A" do tipo Char e instancia ela como o primeiro elemento da variavel x no caso "N"
                    char b = x.ElementAt(1);
                    char c = x.ElementAt(2);
                    // instanciando outras variaveis para comparar o texto da palavra com o texto escrito
                    char h = txtNome.Text.ElementAt(0);
                    char g = txtNome.Text.ElementAt(1);
                    char p = txtNome.Text.ElementAt(2);

                    if (a != h)
                    {
                        cabeça.ImageUrl = "~/Imagens/kyoka.png";
                        Lbl1.Text = "?";

                    }
                    else
                    {
                        Lbl1.Text = "" + h;

                    }

                    if (b != g)
                    {
                        corpo.ImageUrl = "~/Imagens/tronco.png";
                        Lbl2.Text = "?";
                    }
                    else
                    {
                       
                        Lbl2.Text = "" + g;
                    }

                    if (c != p)
                    {
                        perna.ImageUrl = "~/Imagens/pernas.png";
                        Lbl3.Text = "?";
                    }
                    else
                    {
                        
                        Lbl3.Text = "" + p;
                    }
                }
            }

            catch
            {
                txtNome.Text = "campo vazio insira 3 letras";
            }

            
            }

        protected void BtnReiniciar_Click(object sender, EventArgs e)
        {
            Lbl1.Text = "";
            Lbl2.Text = "";
            Lbl3.Text = "";
            cabeça.ImageUrl = "";
            perna.ImageUrl = "";
            corpo.ImageUrl = "";
            txtNome.Text = "";
        }
    }
    }

