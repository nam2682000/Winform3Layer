using BusinessLogic.Interface;
using System.Windows.Forms;

namespace Presentation
{
    public partial class BaoCao : Form
    {
        private readonly ITaiSanService _taiSanService;
        public BaoCao(ITaiSanService taiSanService)
        {
            InitializeComponent();
            _taiSanService = taiSanService;
            var data = _taiSanService.GetBaoCao();
            viewBaoCao.DataSource = data;
        }
        private void viewBaoCao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
