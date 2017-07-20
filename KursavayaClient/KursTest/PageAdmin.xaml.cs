﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace KursTest
{
    /// <summary>
    /// Логика взаимодействия для PageAdmin.xaml
    /// </summary>
    public partial class PageAdmin
    {
        TcpClient _client;
        NetworkStream _stream;
        const int Buffersize = 12;
        readonly byte[] _wait1 = new byte[1];
        String[] _lognemaMas;
        string _login;
        string _messages;
        string _name;
        string _password;
        string _countMes;
        List<User> _listuser;
        readonly Methods _method = new Methods();

        public PageAdmin()
        {
            InitializeComponent();
            tbViewMessages.IsEnabled = false;
            btDel.IsEnabled = false;
            btLoadUsers.IsEnabled = true;
        }

        private void ButtonLoadUsers(object sender, RoutedEventArgs e)
        {
            _client = new TcpClient();
            _client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3084));
            _stream = _client.GetStream();

            //отправляем тип активной страницы
            string typePage = GetType().ToString();
            _method.TypePage(_stream, typePage);

            /*#region Отправляем название кнопки которая нажата
            var methodType = System.Reflection.MethodBase.GetCurrentMethod().Name;
            byte[] methodType_byte = Encoding.Unicode.GetBytes(methodType);
            string methodType_lenght = methodType_byte.Length.ToString();
            byte[] methodType_lenght_byte = Encoding.Unicode.GetBytes(methodType_lenght);
            stream.Write(methodType_lenght_byte, 0, methodType_lenght_byte.Length);
            stream.Read(wait1, 0, wait1.Length);
            stream.Write(methodType_byte, 0, methodType_byte.Length);
            #endregion*/
            var methodType = System.Reflection.MethodBase.GetCurrentMethod().Name;
            _method.Send(_stream, methodType);

            byte[] countLenghtByte = new byte[Buffersize];
            _stream.Read(countLenghtByte, 0, countLenghtByte.Length);
            string countLenght = Encoding.Unicode.GetString(countLenghtByte);

            _stream.Write(_wait1, 0, _wait1.Length);

            byte[] countLenghtEnd = new byte[int.Parse(countLenght)];
            _stream.Read(countLenghtEnd, 0, countLenghtEnd.Length);
            string count = Encoding.Unicode.GetString(countLenghtEnd);

            _listuser = new List<User>(int.Parse(count));

            for (int i = 0; i < int.Parse(count); i++)
            {
                byte[] lognameBuff = new byte[Buffersize];
                _stream.Read(lognameBuff, 0, lognameBuff.Length);
                string lognameLenght = Encoding.Unicode.GetString(lognameBuff);
                _stream.Write(_wait1, 0, _wait1.Length);
                byte[] lognameBuff2 = new byte[int.Parse(lognameLenght)];
                _stream.Read(lognameBuff2, 0, lognameBuff2.Length);
                string logname = Encoding.Unicode.GetString(lognameBuff2);
                _lognemaMas = logname.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                _login = _lognemaMas[0];
                _name = _lognemaMas[1];
                _password = _lognemaMas[2];
                _countMes = _lognemaMas[3];

                lbtest.Items.Add($"{i + 1}.\t  {_login}");

                byte[] otvetRegistra = new byte[2];
                _stream.Read(otvetRegistra, 0, otvetRegistra.Length);
                string yesNo = Encoding.Unicode.GetString(otvetRegistra);
                if (yesNo == "0")
                {
                    _stream.Write(_wait1, 0, _wait1.Length);
                    byte[] messageBuff = new byte[Buffersize];
                    _stream.Read(messageBuff, 0, messageBuff.Length);
                    string mesLenght = Encoding.Unicode.GetString(messageBuff);
                    _stream.Write(_wait1, 0, _wait1.Length);
                    byte[] mesBuff2 = new byte[int.Parse(mesLenght)];
                    _stream.Read(mesBuff2, 0, mesBuff2.Length);
                    string messageText = Encoding.Unicode.GetString(mesBuff2);
                    _messages = messageText;
                    _listuser.Add(new User { Login = _login, Name = _name, Password = _password, Message = _messages, Count = _countMes });
                }
                else
                {
                    _listuser.Add(new User { Login = _login, Name = _name, Password = _password, Count = _countMes });
                }
            }
            btLoadUsers.IsEnabled = false;
        }

        private void ButtonDelete(object sender, RoutedEventArgs e)
        {
            _client = new TcpClient();
            _client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3084));
            _stream = _client.GetStream();

            //отправляем тип активной страницы
            string typePage = GetType().ToString();
            _method.TypePage(_stream, typePage);

            //region Отправляем название кнопки которая нажата
            var methodType = System.Reflection.MethodBase.GetCurrentMethod().Name;
            _method.Send(_stream, methodType);

            var result = (MessageBox.Show("Вы уверены что хотите удалить данного пользователя", "Really", MessageBoxButton.YesNo, MessageBoxImage.Question));
            if (result == MessageBoxResult.Yes)
            {
                var item = lbtest.SelectedItems;
                var itemsMas = item[0].ToString().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                string items = itemsMas[1];
                foreach (var v in lbtest.SelectedItems)
                {
                    lbtest.Items.Remove(v);
                    break;
                }
                tbInfo.Clear(); tbViewMessages.Clear();
                tbInfo.IsEnabled = false; tbViewMessages.IsEnabled = false;

                byte[] selectedByte = Encoding.Unicode.GetBytes(items);
                string selectedLenght = selectedByte.Length.ToString();
                byte[] selectedLenghtByte = Encoding.Unicode.GetBytes(selectedLenght);
                _stream.Write(selectedLenghtByte, 0, selectedLenghtByte.Length);
                _stream.Read(_wait1, 0, _wait1.Length);
                _stream.Write(selectedByte, 0, selectedByte.Length);
            }

        }
        public void ViewMessages()
        {
            tbViewMessages.IsEnabled = true;
            tbViewMessages.Clear();
            var items = lvUsersName.SelectedItems;
            User selected = (User)items[0];
            var userDate = _listuser.First(x => x.Login == selected.Login);
            tbViewMessages.AppendText(userDate.Message);
        }

        private void lvUsersName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lvUsersName.Background = Brushes.Red;
            btDel.IsEnabled = true;
            tbInfo.IsEnabled = true;
            tbInfo.Clear();
            tbInfo.Height = 150;
            tbInfo.Width = 270;

            var items = lvUsersName.SelectedItems;
            if (items.Count != 0)
            {
                User selected = (User)items[0];


                var a = _listuser.First(i => i.Login == selected.Login);
                tbInfo.AppendText($"Login: {a.Login}{Environment.NewLine}{Environment.NewLine}Name: {a.Name}{Environment.NewLine}{Environment.NewLine}Password: {a.Password}{Environment.NewLine}{Environment.NewLine}Количество сообщений: {a.Count}");
                ViewMessages();
            }
            else
            {
                btDel.IsEnabled = false;
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var result = (MessageBox.Show("Вы уверены что хотите выйти?", "Really", MessageBoxButton.YesNo, MessageBoxImage.Question));
            if (result == MessageBoxResult.Yes)
            {
                ((ContentControl)Parent).Content = new PageMain();
            }
        }

        public void ViewMessages2()
        {
            tbViewMessages.IsEnabled = true;
            tbViewMessages.Clear();
            var item = lbtest.SelectedItems;
            var itemsMas = item[0].ToString().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string items = itemsMas[1];
            var userDate = _listuser.First(x => x.Login == items);
            tbViewMessages.AppendText(userDate.Message);
        }
        private void lbtest_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lvUsersName.Background = Brushes.Red;
            btDel.IsEnabled = true;
            tbInfo.IsEnabled = true;
            tbInfo.Clear();
            tbInfo.Height = 150;
            tbInfo.Width = 201;

            var item = lbtest.SelectedItems;
            if (item.Count == 0)
            {
                lbtest.SelectedIndex = -1;
            }
            else
            {
                var itemsMas = item[0].ToString().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                string items = itemsMas[1];
                if (item.Count != 0)
                {
                    var a = _listuser.First(i => i.Login == items);
                    tbInfo.AppendText($"Login: {a.Login}{Environment.NewLine}{Environment.NewLine}Name: {a.Name}{Environment.NewLine}{Environment.NewLine}Password: {a.Password}{Environment.NewLine}{Environment.NewLine}Количество сообщений: {a.Count}");
                    ViewMessages2();
                }
                else
                {
                    btDel.IsEnabled = false;
                }
            }
        }
    }
}