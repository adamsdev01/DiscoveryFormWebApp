using DiscoveryFormWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiscoveryFormWebApp.Data.Services
{
    public class DiscoveryFormService : IDiscoveryFormService
    {
        readonly DiscoveryFormDBContext _dbContext = new();
        public DiscoveryFormService(DiscoveryFormDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //To Get all DiscoveryForm 
        public List<DiscoveryForm> GetListOfDiscoveryForms()
        {
            try
            {
                return _dbContext.DiscoveryForms.ToList();
            }
            catch
            {
                throw;
            }
        }
        //To Add new DiscoveryForm record
        public void AddDiscoveryForm(DiscoveryForm discoveryForm)
        {
            try
            {
                discoveryForm.InsertedDate = DateTime.Now;
                discoveryForm.CurrentFlag = "Y";
                _dbContext.DiscoveryForms.Add(discoveryForm);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //To Update the records of a particluar DiscoveryForm
        public void UpdateDiscoveryFormDetails(DiscoveryForm discoveryForm)
        {
            try
            {
                var existingRecord = _dbContext.DiscoveryForms.FirstOrDefault(x => x.UniqueDiscoveryFormId == discoveryForm.UniqueDiscoveryFormId);
                if (existingRecord != null)
                {
                    existingRecord.Title = discoveryForm.Title;
                    existingRecord.Description = discoveryForm.Description;
                    existingRecord.Category = discoveryForm.Category;
                    existingRecord.ApprovalStatus = discoveryForm.ApprovalStatus;
                    existingRecord.VisibilityStatus = discoveryForm.VisibilityStatus;
                    existingRecord.Notes = discoveryForm.Notes;

                    existingRecord.CurrentFlag = "Y";
                    discoveryForm.UpdatedDate = DateTime.Now;                   
                }
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular DiscoveryForm
        public DiscoveryForm GetDiscoveryFormData(int uniqueDiscoveryFormId)
        {
            try
            {
                DiscoveryForm? discoveryForm = _dbContext.DiscoveryForms
                    .Where(d => d.CurrentFlag == "Y" && d.UniqueDiscoveryFormId == uniqueDiscoveryFormId)
                    .FirstOrDefault();
                if (discoveryForm != null)
                {
                    return discoveryForm;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular DiscoveryForm
        public void DeleteDiscoveryForm(int uniqueDiscoveryFormId)
        {
            try
            {
                DiscoveryForm? discoveryForm = _dbContext.DiscoveryForms.Find(uniqueDiscoveryFormId);
                if (discoveryForm != null)
                {
                    discoveryForm.CurrentFlag = "N";
                    discoveryForm.UpdatedDate = DateTime.Now;
                    //_dbContext.DiscoveryForms.Remove(discoveryForm);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
