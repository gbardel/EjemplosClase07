//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSDaysOperationsSVC
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSDaysOperationsSVC.IDayOperations")]
    public interface IDayOperations
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDayOperations/ConvertToDays", ReplyAction="http://tempuri.org/IDayOperations/ConvertToDaysResponse")]
        int ConvertToDays(int day, int month, int year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDayOperations/ConvertToDays", ReplyAction="http://tempuri.org/IDayOperations/ConvertToDaysResponse")]
        System.Threading.Tasks.Task<int> ConvertToDaysAsync(int day, int month, int year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDayOperations/DaysBetweenDates", ReplyAction="http://tempuri.org/IDayOperations/DaysBetweenDatesResponse")]
        int DaysBetweenDates(int day1, int month1, int year1, int day2, int month2, int year2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDayOperations/DaysBetweenDates", ReplyAction="http://tempuri.org/IDayOperations/DaysBetweenDatesResponse")]
        System.Threading.Tasks.Task<int> DaysBetweenDatesAsync(int day1, int month1, int year1, int day2, int month2, int year2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDayOperations/AddDays", ReplyAction="http://tempuri.org/IDayOperations/AddDaysResponse")]
        string AddDays(int day, int month, int year, int days);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDayOperations/AddDays", ReplyAction="http://tempuri.org/IDayOperations/AddDaysResponse")]
        System.Threading.Tasks.Task<string> AddDaysAsync(int day, int month, int year, int days);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDayOperations/SubtractDays", ReplyAction="http://tempuri.org/IDayOperations/SubtractDaysResponse")]
        string SubtractDays(int day, int month, int year, int days);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDayOperations/SubtractDays", ReplyAction="http://tempuri.org/IDayOperations/SubtractDaysResponse")]
        System.Threading.Tasks.Task<string> SubtractDaysAsync(int day, int month, int year, int days);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDayOperationsChannel : WSDaysOperationsSVC.IDayOperations, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DayOperationsClient : System.ServiceModel.ClientBase<WSDaysOperationsSVC.IDayOperations>, WSDaysOperationsSVC.IDayOperations
    {
        
        public DayOperationsClient()
        {
        }
        
        public DayOperationsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public DayOperationsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public DayOperationsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public DayOperationsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public int ConvertToDays(int day, int month, int year)
        {
            return base.Channel.ConvertToDays(day, month, year);
        }
        
        public System.Threading.Tasks.Task<int> ConvertToDaysAsync(int day, int month, int year)
        {
            return base.Channel.ConvertToDaysAsync(day, month, year);
        }
        
        public int DaysBetweenDates(int day1, int month1, int year1, int day2, int month2, int year2)
        {
            return base.Channel.DaysBetweenDates(day1, month1, year1, day2, month2, year2);
        }
        
        public System.Threading.Tasks.Task<int> DaysBetweenDatesAsync(int day1, int month1, int year1, int day2, int month2, int year2)
        {
            return base.Channel.DaysBetweenDatesAsync(day1, month1, year1, day2, month2, year2);
        }
        
        public string AddDays(int day, int month, int year, int days)
        {
            return base.Channel.AddDays(day, month, year, days);
        }
        
        public System.Threading.Tasks.Task<string> AddDaysAsync(int day, int month, int year, int days)
        {
            return base.Channel.AddDaysAsync(day, month, year, days);
        }
        
        public string SubtractDays(int day, int month, int year, int days)
        {
            return base.Channel.SubtractDays(day, month, year, days);
        }
        
        public System.Threading.Tasks.Task<string> SubtractDaysAsync(int day, int month, int year, int days)
        {
            return base.Channel.SubtractDaysAsync(day, month, year, days);
        }
    }
}
