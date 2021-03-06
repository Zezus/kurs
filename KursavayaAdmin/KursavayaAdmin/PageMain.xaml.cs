﻿using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace KursavayaAdmin
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        TcpClient _client;
        NetworkStream _stream;
        bool _flag = true;
        Methods method = new Methods();

        public PageMain()
        {
            InitializeComponent();
        }

        public bool TestDate(string log, string pas)
        {
            if (log == "admin" && pas == "admin")
            {

            }
            else
            {
                _flag = false;
            }
            return _flag;
        }

        private void butLogin_Click(object sender, RoutedEventArgs e)
        {
            TestDate(tbLogin.Text, tbPassword.Password);
            if (_flag)
            {
                _client = new TcpClient();
                _client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3084));
                _stream = _client.GetStream();

                //отправляем тип активной страницы
                string typePage = GetType().ToString();
                method.TypePage(_stream, typePage);

                //отправляем данные с входа
                string userData = tbLogin.Text + " " + tbPassword.Password;
                method.Send(_stream, userData);

                byte[] otvetRegistra = new byte[2];
                _stream.Read(otvetRegistra, 0, otvetRegistra.Length);
                string yesNo = Encoding.Unicode.GetString(otvetRegistra);
                if (yesNo == "0")
                {
                    if (tbLogin.Text == "admin" && tbPassword.Password == "admin")
                    {
                        ((ContentControl)Parent).Content = new PageAdmin();
                        MessageBox.Show("Авторизация прошла успешно, теперь вы можете войти в чат", "Goog Job", MessageBoxButton.OK);
                    }
                    else
                    {
                        MessageBox.Show("Данные не верны", "Goog Job", MessageBoxButton.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Error", MessageBoxButton.OK);
                    tbPassword.Clear();
                }

                // ((ContentControl)(this.Parent)).Content = new PageChat();

            }
        }
        
       /* private void ButtonRememberPas(object sender, RoutedEventArgs e)
        {
            ((ContentControl)Parent).Content = new RemindPassword();
        }*/
    }
}
