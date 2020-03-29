using System.ComponentModel;
using Prism.AppModel;

namespace StepperRoundingIssue.ViewModels
{
    sealed class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public decimal TwoFractionValueMaterial { get; set; } = new decimal(4.99);
        
        public decimal OneFractionValueMaterial { get; set; }= new decimal(4.99);
        
        public decimal TwoFractionValue { get; set; }= new decimal(4.99);
        
        public decimal OneFractionValue { get; set; }= new decimal(4.99);
    }
}