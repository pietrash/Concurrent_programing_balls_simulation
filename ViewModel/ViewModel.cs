using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Model;

namespace ViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {
        private readonly ModelApi model = new();


        public ObservableCollection<Orb> OrbList
        {
            get { return model.orbs; }
            set
            {
                model.orbs = value;
                OnPropertyChanged(nameof(OrbList));
            }
        }


        public ViewModel()
        {
            StartButton = new Signal(Enable);
            StopButton = new Signal(Disable);
            model.resizeMode = ResizeMode.CanResize;
            model.isEnabled = false;
        }

        public string OrbQuantity
        {
            get
            {
                return Convert.ToString(model.orbQuantity);
            }
            set
            {
                int temp = model.orbQuantity;
                try
                {
                    model.orbQuantity = Convert.ToInt32(value);
                }
                catch
                {
                    OrbQuantity = temp.ToString();
                }

                OnPropertyChanged(nameof(OrbQuantity));
            }
        }

        public ResizeMode ResizeMode
        {
            get { return model.resizeMode; }
            set
            {
                model.resizeMode = value;
                OnPropertyChanged(nameof(ResizeMode));
            }
        }

        public double WindowHeight
        {
            get { return model.windowHeight; }
            set
            {
                model.windowHeight = value;
                OnPropertyChanged(nameof(WindowHeight));
            }
        }

        public double WindowWidth
        {
            get { return model.windowWidth; }
            set
            {
                model.windowWidth = value;
                OnPropertyChanged(nameof(WindowWidth));
            }
        }

        public ICommand StartButton { get; set; }

        public ICommand StopButton { get; set; }

        public bool IsEnabled
        {
            get { return model.isEnabled; }
            set
            {
                model.isEnabled = value;
                OnPropertyChanged(nameof(IsEnabled));
                OnPropertyChanged(nameof(IsDisabled));
            }
        }

        public bool IsDisabled
        {
            get { return !IsEnabled; }
        }

        public ObservableCollection<Orb> Orbs
        {
            get { return model.orbs; }
        }


        private void Enable()
        {
            ResizeMode = ResizeMode.NoResize;
            IsEnabled = true;
            model.Enable();
        }

        private void Disable()
        {
            ResizeMode = ResizeMode.CanResize;
            IsEnabled = false;
            model.Disable();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
