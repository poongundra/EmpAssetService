using EmpAssetService.Models;

namespace EmpAssetService.Data
{
    public interface IEmpAssetRepository
    {
        bool SaveChanges();
        IEnumerable<EmpAsset> GetEmpAssetDetails();

        EmpAsset GetEmpAssetDetailsbyId(int id);

        void CreateEmpAssetDetails(EmpAsset empAsset);
    }
}
