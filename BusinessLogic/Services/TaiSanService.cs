using BusinessLogic.Dtos;
using BusinessLogic.Interface;
using DataAccess.Dtos;
using DataAccess.Entities;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Service
{
    public class TaiSanService : ITaiSanService
    {
        private readonly ITaiSanRepository _taiSanRepository;
        public TaiSanService(ITaiSanRepository taiSanRepository)
        {
            _taiSanRepository = taiSanRepository;
        }

        public bool AddTaiSan(TaiSanDto taiSanDto)
        {
            bool result = false;
            result = _taiSanRepository.AddTaiSan(new TaiSan
            {
                ChiNhanhQL = taiSanDto.ChiNhanhQL,
                ChiNhanhTT = taiSanDto.ChiNhanhTT,
                HangSX = taiSanDto.HangSX,
                KyHieu = taiSanDto.KyHieu,
                NamSD = taiSanDto.NamSD,
                SoMay = taiSanDto.SoMay,
                SoNamSD = taiSanDto.SoNamSD,
                TenTaiSan = taiSanDto.TenTaiSan,
                TinhTrang = taiSanDto.TinhTrang,
                TrangThai = taiSanDto.TrangThai,
                ViTri = taiSanDto.ViTri,
            });
            return result;
        }

        public bool DeleteTaiSan(string soThe)
        {
            return _taiSanRepository.DeleteTaiSan(soThe);
        }

        public List<TaiSanDto> GetAll()
        {
            var data = _taiSanRepository.GetAllTaiSan();
            return data.Select(m => new TaiSanDto
            {
                SoThe = m.SoThe,
                ChiNhanhQL = m.ChiNhanhQL,
                ChiNhanhTT = m.ChiNhanhTT,
                HangSX = m.HangSX,
                KyHieu = m.KyHieu,
                NamSD = m.NamSD,
                SoMay = m.SoMay,
                SoNamSD = m.SoNamSD,
                TenTaiSan = m.TenTaiSan,
                TinhTrang = m.TinhTrang,
                TrangThai = m.TrangThai,
                ViTri = m.ViTri,
            }).ToList();
        }

        public bool UpdateTaiSan(TaiSanDto taiSanDto)
        {
            return _taiSanRepository.UpdateTaiSan(new TaiSan
            {
                SoThe = taiSanDto.SoThe,
                ChiNhanhQL = taiSanDto.ChiNhanhQL,
                ChiNhanhTT = taiSanDto.ChiNhanhTT,
                HangSX = taiSanDto.HangSX,
                KyHieu = taiSanDto.KyHieu,
                NamSD = taiSanDto.NamSD,
                SoMay = taiSanDto.SoMay,
                SoNamSD = taiSanDto.SoNamSD,
                TenTaiSan = taiSanDto.TenTaiSan,
                TinhTrang = taiSanDto.TinhTrang,
                TrangThai = taiSanDto.TrangThai,
                ViTri = taiSanDto.ViTri,
            });
        }
        public string GenerateSoThe()
        {
            var maxSoThe = _taiSanRepository.GetMaxSoThe();
            var nextId = maxSoThe + 1;
            return "TS" + nextId.ToString("D8");
        }

        public TaiSanDto Get(string soThe)
        {
            var result = _taiSanRepository.GetTaiSan(soThe);
            return new TaiSanDto
            {
                SoThe = result.SoThe,
                ChiNhanhQL = result.ChiNhanhQL,
                ChiNhanhTT = result.ChiNhanhTT,
                HangSX = result.HangSX,
                KyHieu = result.KyHieu,
                NamSD = result.NamSD,
                SoMay = result.SoMay,
                SoNamSD = result.SoNamSD,
                TenTaiSan = result.TenTaiSan,
                TinhTrang = result.TinhTrang,
                TrangThai = result.TrangThai,
                ViTri = result.ViTri,
            };
        }

        public List<TaiSanDto> GetTaiSanFilter(string chiNhanh, string trangThai)
        {
            var data = _taiSanRepository.GetTaiSanFilter(chiNhanh, trangThai);
            return data.Select(m => new TaiSanDto
            {
                SoThe = m.SoThe,
                ChiNhanhQL = m.ChiNhanhQL,
                ChiNhanhTT = m.ChiNhanhTT,
                HangSX = m.HangSX,
                KyHieu = m.KyHieu,
                NamSD = m.NamSD,
                SoMay = m.SoMay,
                SoNamSD = m.SoNamSD,
                TenTaiSan = m.TenTaiSan,
                TinhTrang = m.TinhTrang,
                TrangThai = m.TrangThai,
                ViTri = m.ViTri,
            }).ToList();
        }

        public List<BaoCaoChiNhanhDto> GetBaoCao()
        {
            var data = _taiSanRepository.GetBaoCaoChiNhanh(null);
            return data.Select(m => new BaoCaoChiNhanhDto
            {
                ChiNhanhQL = m.ChiNhanhQL,
                SoLuongHon5Nam = m.SoLuongHon5Nam,
                SoLuongKhongSuDung = m.SoLuongKhongSuDung,
                SoLuongSuDung = m.SoLuongSuDung,
                SoLuongTaiSan = m.SoLuongTaiSan,
                TiLeSuDung = Math.Round(m.TiLeSuDung, 2),
                TyLeTaiSanLonHon5Nam = Math.Round(m.TyLeTaiSanLonHon5Nam, 2)
            }).ToList();
        }
    }
}
