using DataAccess.Dtos;
using DataAccess.Entities;
using System.Collections.Generic;

namespace DataAccess.Interfaces
{
    public interface ITaiSanRepository
    {
        List<TaiSan> GetAllTaiSan();
        List<TaiSan> GetTaiSanFilter(string chiNhanh, string trangThai);
        bool AddTaiSan(TaiSan user);
        bool UpdateTaiSan(TaiSan user);
        bool DeleteTaiSan(string soThe);
        TaiSan GetTaiSan(string soThe);
        bool IsDuplicateSoThe(string soThe);
        int GetMaxSoThe();
        List<BaoCaoChiNhanhDto> GetBaoCaoChiNhanh(string chiNhanhQl);
    }
}
