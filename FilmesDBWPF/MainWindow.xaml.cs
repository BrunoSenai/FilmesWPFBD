using FilmesDBWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FilmesDBWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {

            Context ctx = new Context();
            Filme f = new Filme();

            f.Titulo = txtTitulo.Text;
            f.Nota = Convert.ToDouble(txtNota.Text.Replace(".",","));

            ctx.Filmes.Add(f);
            ctx.SaveChanges();

            txtTitulo.Clear();
            txtNota.Clear();

            gridFilmes.ItemsSource = ctx.Filmes.ToList();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.ListarDados();
        }

        private void ListarDados()
        {
            Context ctx = new Context();
            gridFilmes.ItemsSource = ctx.Filmes.ToList();
        }

    }
}
