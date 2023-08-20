using DiscoveryFormWebApp.Models;

namespace DiscoveryFormWebApp.Data.Services
{
    public interface IDiscoveryFormService
    {
        public List<DiscoveryForm> GetListOfDiscoveryForms();
        public void AddDiscoveryForm(DiscoveryForm discoveryForm);
        public void UpdateDiscoveryFormDetails(DiscoveryForm discoveryForm);
        public DiscoveryForm GetDiscoveryFormData(int uniqueDiscoveryFormId);
        public void DeleteDiscoveryForm(int uniqueDiscoveryFormId);
    }
}
