using EmpAssetService.Models;
using System;

namespace EmpAssetService.Data
{
    public class EmpAssetRepository : IEmpAssetRepository
    {
        private readonly AppDbContext _appDbContext;

        public EmpAssetRepository (AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void CreateEmpAssetDetails(EmpAsset empAsset)
        {
            _appDbContext.Add<EmpAsset>(empAsset);
        }

        public IEnumerable<EmpAsset> GetEmpAssetDetails()
        {
            return _appDbContext.EmpAsset.ToList();
        }

        public EmpAsset GetEmpAssetDetailsbyId(int id)
        {
            return _appDbContext.EmpAsset.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return (_appDbContext.SaveChanges() >= 0);
        }
    }
}
