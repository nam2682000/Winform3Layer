using BusinessLogic.Dtos;
using DataAccess.Dtos;
using DataAccess.Entities;
using System.Collections.Generic;

namespace BusinessLogic.Interface
{
    public interface ITaiSanService
    {
        bool AddTaiSan(TaiSanDto taiSanDto);
        List<TaiSanDto> GetAll();
        List<BaoCaoChiNhanhDto> GetBaoCao();
        TaiSanDto Get(string soThe);
        bool UpdateTaiSan(TaiSanDto taiSanDto);
        bool DeleteTaiSan(string soThe);
        string GenerateSoThe();
        List<TaiSanDto> GetTaiSanFilter(string chiNhanh, string trangThai);
    }
}
