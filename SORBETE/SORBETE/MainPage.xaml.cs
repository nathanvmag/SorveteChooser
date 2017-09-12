using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SORBETE
{
    public partial class MainPage : MasterDetailPage
    {
        ContentPage baunilia;
        ContentPage inicial;
        public MainPage()
        {
            InitializeComponent();
            var st = new StackLayout
            {
                Children =
                    {
                    new Label()
                    {
                        Text = "SELECIONE DELICIAS",
                        HorizontalOptions = LayoutOptions.Center
                        ,
                        FontSize = 18
                    }

            }
            };
            Button bt = new Button
            {
                Text = "Baunilia"
               , BackgroundColor = Color.Black
               , TextColor = Color.WhiteSmoke
            };
            Button bt2 = new Button
            {
                Text = "Menu",
                BackgroundColor = Color.Blue,
                TextColor = Color.White
            };
            Button bt3 = new Button
            {
                Text = "Chocolate"
             ,
                BackgroundColor = Color.Brown
                , TextColor = Color.White
            };
            Button bt4 = new Button
            {
                Text = "Morangotango"
             ,
                BackgroundColor = Color.Red
                ,
                TextColor = Color.White
            };
            Button bt5 = new Button
            {
                Text = "Flocos"
             ,
                BackgroundColor = Color.White
            };
            Button bt6 = new Button
            {
                Text = "Pistache"
             ,
                BackgroundColor = Color.Green
                ,
                TextColor = Color.White
            };
            Button bt7 = new Button
            {
                Text = "Abacaxi"
           ,
                BackgroundColor = Color.Yellow
              ,
                TextColor = Color.Green
            };
            Button bt8 = new Button
            {
                Text = "Laranja"
          ,
                BackgroundColor = Color.Orange
             ,
                TextColor = Color.White
            };
            bt2.Clicked += delegate { Detail = inicial; };
            bt.Clicked += delegate { Detail = creator("Baunilia", "baunilia.jpg"); };
            bt3.Clicked += delegate { Detail = creator("Chocolate", "chocolate.jpg"); };
            bt4.Clicked += delegate { Detail = creator("Morangotango", "morango.jpg"); };
            bt5.Clicked += delegate { Detail = creator("Flocos", "flocos.jpg"); };
            bt6.Clicked += delegate { Detail = creator("Pistache", "pistache.jpg"); };
            bt7.Clicked += delegate { Detail = creator("Abacaxi", "abacaxi.jpg"); };
            bt8.Clicked += delegate { Detail = creator("Laranja", "laranja.jpg"); };
            st.Children.Add(bt2);
            st.Children.Add(bt);
            st.Children.Add(bt3);
            st.Children.Add(bt4);
            st.Children.Add(bt5);
            st.Children.Add(bt6);
            st.Children.Add(bt7);
            st.Children.Add(bt8);
            Master = new ContentPage
            {
                Content = st, Title = "master"
            };


            inicial = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label()
                        {
                            Text="ARRASTE PARA A DIREITA PARA SELECIONAR SUA DELICIA PREFERIDAAAAA",
                            HorizontalOptions = LayoutOptions.Center,
                            TextColor=Color.SteelBlue,
                            FontSize=30

                        }
                    }
                }
            };
            baunilia = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label()
                        {
                            Text="Baulinia is good",
                            HorizontalOptions = LayoutOptions.Center

                        }
                    }
                }
            };
            Detail = inicial;
        }

        private void Bt_Clicked(object sender, EventArgs e)
        {
            Detail = baunilia;
        }
        ContentPage creator(string title, string imagePath)
        {
            DependencyService.Get<INatives>().notify("Sorvete de " + title + " é bom", "Você escolheu muito bem o sorvete de " + title);
            return new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label()
                        {

                            Text=title,
                            HorizontalOptions = LayoutOptions.Center,
                            TextColor= Color.HotPink,
                            FontSize = 20


                        }
                        , new Image()
                        {
                            Source=ImageSource.FromFile(imagePath),
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions= LayoutOptions.Center,
                            Aspect = Aspect.AspectFit
                        }

                    }
                }
            };
        }


    }
    public interface INatives     {
        void notify(string title, string contentTitle);
    }
}
