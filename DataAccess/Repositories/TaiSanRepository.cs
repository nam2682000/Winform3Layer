using Dapper;
using DataAccess.DbContext;
using DataAccess.Dtos;
using DataAccess.Entities;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataAccess.Repositories
{
    public class TaiSanRepository : ITaiSanRepository
    {
        private readonly DbContexApplication _context;

        public TaiSanRepository(DbContexApplication context)
        {
            _context = context;
        }

        public List<TaiSan> GetAllTaiSan()
        {
            using (var connection = _context.CreateConnection())
            {
                const string query = "SELECT * FROM TaiSan";
                return connection.Query<TaiSan>(query).ToList();
            }
        }

        public bool AddTaiSan(TaiSan taiSan)
        {
            using (var connection = _context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@TenTaiSan", taiSan.TenTaiSan);
                parameters.Add("@KyHieu", taiSan.KyHieu);
                parameters.Add("@SoMay", taiSan.SoMay);
                parameters.Add("@HangSX", taiSan.HangSX);
                parameters.Add("@NamSD", taiSan.NamSD);
                parameters.Add("@SoNamSD", taiSan.SoNamSD);
                parameters.Add("@TinhTrang", taiSan.TinhTrang);
                parameters.Add("@TrangThai", taiSan.TrangThai);
                parameters.Add("@ChiNhanhQL", taiSan.ChiNhanhQL);
                parameters.Add("@ChiNhanhTT", taiSan.ChiNhanhTT);
                parameters.Add("@ViTri", taiSan.ViTri);

                var result = connection.QueryFirstOrDefault(
                "pr_AddTaiSan",
                parameters,
                commandType: CommandType.StoredProcedure);
                if (result == "Số thẻ đã tồn tại")
                {
                    return false;
                }
                return true;
            }
        }

        public bool UpdateTaiSan(TaiSan taiSan)
        {
            using (var connection = _context.CreateConnection())
            {
                var result = connection.Query(
                "pr_UpdateTaiSan",
                taiSan,
                commandType: CommandType.StoredProcedure);
                return true;
            }
        }

        public bool DeleteTaiSan(string soThe)
        {
            using (var connection = _context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@SoThe", soThe);
                var result = connection.Query(
                "pr_DeleteTaiSan",
                parameters,
                commandType: CommandType.StoredProcedure);
                return true;
            }
        }

        public bool IsDuplicateSoThe(string soThe)
        {
            using (var connection = _context.CreateConnection())
            {
                string query = "SELECT COUNT(1) FROM TaiSan WHERE SoThe = @SoThe";
                return connection.ExecuteScalar<int>(query, new { SoThe = soThe }) > 0;
            }
        }

        public int GetMaxSoThe()
        {
            using (var connection = _context.CreateConnection())
            {
                string query = "SELECT MAX(SoThe) FROM TaiSan";
                return connection.QueryFirstOrDefault<int>(query);
            }
        }

        public List<BaoCaoChiNhanhDto> GetBaoCaoChiNhanh(string chiNhanhQl)
        {
            using (var connection = _context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                var result = connection.Query<BaoCaoChiNhanhDto>(
                "pr_BaoCao",
                parameters,
                commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public TaiSan GetTaiSan(string soThe)
        {
            using (var connection = _context.CreateConnection())
            {
                const string query = "SELECT * FROM TaiSan WHERE SoThe = @SoThe";
                return connection.QueryFirst<TaiSan>(query, new {SoThe = soThe});
            }
        }

        public List<TaiSan> GetTaiSanFilter(string chiNhanh, string trangThai)
        {
            using (var connection = _context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                if (chiNhanh != null)
                {
                    parameters.Add("@ChiNhanhQL", chiNhanh);
                }
                if (trangThai != null)
                {
                    parameters.Add("@TrangThai", trangThai);
                }
                var result = connection.Query<TaiSan>(
                "pr_TaiSanFillter",
                parameters,
                commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }
    }
}
