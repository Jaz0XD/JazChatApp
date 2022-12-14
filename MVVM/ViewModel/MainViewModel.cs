using JazChatApp.Core;
using JazChatApp.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazChatApp.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {

        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }


        // Commands
        public RelayCommand SendCommand { get; set;}

        private ContactModel _selectedContact;
        public ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                _selectedContact = value;
                OnPropertyChanged();
            }
        }

        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; OnPropertyChanged(); }
        }




        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel
            {
                    Message = Message,
                    FirstMessage = false
                });

                Message = "";

            });

            Messages.Add(new MessageModel
            {
                Username = "JazXD",
                UsernameColor = "#409aff",
                ImageSource = "https://w7.pngwing.com/pngs/314/114/png-transparent-laughing-emoji.png",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            for (int i=0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "JazXD",
                    UsernameColor = "#409aff",
                    ImageSource = "https://w7.pngwing.com/pngs/314/114/png-transparent-laughing-emoji.png",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false
                });
            }

            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Jaris",
                    UsernameColor = "#409aff",
                    ImageSource = "https://w7.pngwing.com/pngs/314/114/png-transparent-laughing-emoji.png",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                });
            }

            Messages.Add(new MessageModel
            {
                Username = "Jaris",
                UsernameColor = "#409aff",
                ImageSource = "https://w7.pngwing.com/pngs/314/114/png-transparent-laughing-emoji.png",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = true,
            });

            for (int i = 0; i <5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"JazXD {i}",
                    ImageSource = "https://w7.pngwing.com/pngs/314/114/png-transparent-laughing-emoji.png",
                    Messages = Messages
                });
            }
        }

    }
}
